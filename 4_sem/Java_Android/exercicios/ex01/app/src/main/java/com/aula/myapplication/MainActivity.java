package com.aula.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    public void Calc(View view){
        int id=view.getId();
        switch (id){
            case R.id.textView2:
                R.id.textView2=R.id.editTextTextPersonName;
        }
    }
}