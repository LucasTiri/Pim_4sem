using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using CamadaMobileAndroid.Resources.modelo;

namespace CamadaMobileAndroid.Resources.ListAdapter
{
    class listViewAdapter : BaseAdapter
    {
        private readonly Activity context;
        private readonly List<aluno> alunos;

        public listViewAdapter(Activity _context, List<aluno> _alunos)
        {
            this.context = _context;
            this.alunos = _alunos;
        }

        public override int Count
        {
            get
            {
                return alunos.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return alunos[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? context.LayoutInflater.Inflate(Resource.Layout.ListViewLayoutUnip, parent, false);

            var lvtxtNome = view.FindViewById<TextView>(Resource.Id.txtvNome);
            var lvtxtRg = view.FindViewById<TextView>(Resource.Id.txtvRg);
            var lvtxtCpf = view.FindViewById<TextView>(Resource.Id.txtvCpf);

            lvtxtNome.Text = alunos[position].Nome;
            lvtxtRg.Text = "" + alunos[position].Rg;
            lvtxtCpf.Text = alunos[position].Cpf;

            return view;

        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }
    }
}

