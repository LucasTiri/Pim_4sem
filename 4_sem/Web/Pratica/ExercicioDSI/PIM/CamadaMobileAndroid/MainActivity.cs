using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using CamadaMobileAndroid.Resources.ListAdapter;
using CamadaMobileAndroid.Resources.modelo;
using static CamadaMobileAndroid.Resources.DataBaseHelper.dataBase;

namespace CamadaMobileAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView lvDados;
        List<aluno> listaAlunos = new List<aluno>();
        DataBase db;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_main);
            //criar banco de dados
            CriarBancoDados();
            lvDados = FindViewById<ListView>(Resource.Id.lvDados);
            var txtNome = FindViewById<EditText>(Resource.Id.txtNome);
            var txtRg = FindViewById<EditText>(Resource.Id.txtRg);
            var txtCpf = FindViewById<EditText>(Resource.Id.txtCpf);
            var btnIncluir = FindViewById<Button>(Resource.Id.btnIncluir);
            var btnEditar = FindViewById<Button>(Resource.Id.btnEditar);
            var btnDeletar = FindViewById<Button>(Resource.Id.btnDeletar);
            //carregar Dados
            CarregarDados();
            //botão Incluir
            btnIncluir.Click += delegate
            {
                aluno _aluno = new aluno()
                {
                    Nome = txtNome.Text,
                    Rg = txtRg.Text,
                    Cpf = txtCpf.Text
                };
                db.InserirAluno(_aluno);
                txtNome.Text = string.Empty;
                txtCpf.Text = string.Empty;
                txtRg.Text = string.Empty;
                CarregarDados();
            };
            //botão editar
            btnEditar.Click += delegate
            {
                aluno _aluno = new aluno()
                {
                    Id = int.Parse(txtNome.Tag.ToString()),
                    Nome = txtNome.Text,
                    Rg = txtRg.Text,
                    Cpf = txtCpf.Text
                };
                db.AtualizarAluno(_aluno);
                txtNome.Text = string.Empty;
                txtCpf.Text = string.Empty;
                txtRg.Text = string.Empty;                
                CarregarDados();
            };
            //botão deletar
            btnDeletar.Click += delegate
            {
                aluno _aluno = new aluno()
                {
                    Id = int.Parse(txtNome.Tag.ToString()),
                    Nome = txtNome.Text,
                    Rg = txtRg.Text,
                    Cpf = txtCpf.Text
                };
                db.DeletarAluno(_aluno);
                txtNome.Text = string.Empty;
                txtCpf.Text = string.Empty;
                txtRg.Text = string.Empty;
                CarregarDados();
            };
            //evento itemClick do ListView
            lvDados.ItemClick += (s, e) =>
            {
                for (int i = 0; i < lvDados.Count; i++)
                {
                    if (e.Position == i)
                        lvDados.GetChildAt(i).SetBackgroundColor(Android.Graphics.Color.Chocolate);
                    else
                        lvDados.GetChildAt(i).SetBackgroundColor(Android.Graphics.Color.Transparent);
                }
                //vinculando dados do listview 
                var lvtxtNome = e.View.FindViewById<TextView>(Resource.Id.txtvNome);
                var lvtxtRg = e.View.FindViewById<TextView>(Resource.Id.txtvRg);
                var lvtxtCpf = e.View.FindViewById<TextView>(Resource.Id.txtvCpf);
                txtNome.Text = lvtxtNome.Text;
                txtNome.Tag = e.Id;
                txtRg.Text = lvtxtRg.Text;
                txtCpf.Text = lvtxtCpf.Text;
            };
        }
        //rotina para criar o banco de dados
        private void CriarBancoDados()
        {
            db = new DataBase();
            db.CriarBancoDeDados();
        }
        //Obtem todos os alunos da tabela Aluno e exibe no ListView
        private void CarregarDados()
        {
            listaAlunos = db.GetAlunos();
            var adapter = new listViewAdapter(this, listaAlunos);
            lvDados.Adapter = adapter;
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
	}
}

