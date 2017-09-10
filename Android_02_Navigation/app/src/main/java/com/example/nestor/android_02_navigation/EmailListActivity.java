package com.example.nestor.android_02_navigation;

import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.MenuItem;
import android.view.View;
import android.content.Intent;
import android.widget.EditText;

public class EmailListActivity extends AppCompatActivity {

    private EditText txtName, txtEmail;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_email_list);

        //Set toolbar menu option (Checkmark)
        //noinspection ConstantConditions
        getSupportActionBar().setHomeAsUpIndicator(R.drawable.ic_checkmark);

        //Get data from origin intent
        Intent intent = getIntent();
        String name = intent.getStringExtra(MainActivity.NAME_KEY);
        String email= intent.getStringExtra(MainActivity.EMAIL_KEY);

        //Set textviews with data
        txtName = (EditText) findViewById(R.id.name_text);
        txtName.setText(name);
        txtEmail = (EditText) findViewById(R.id.email_address);
        txtEmail .setText(email);
    }

    @Override
    public void onBackPressed() {

        //Get data from textfields
        String nameTxt = txtName.getText().toString();
        String emailTxt = txtEmail.getText().toString();

        Intent intent = new Intent();
        intent.putExtra(MainActivity.NAME_KEY, nameTxt);
        intent.putExtra(MainActivity.EMAIL_KEY, emailTxt);
        setResult(RESULT_OK, intent);

        finish();
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        if(item.getItemId() == android.R.id.home) //Identifier for the up botton at the action bar
        {
            onBackPressed();
            return true;
        }
        return super.onOptionsItemSelected(item);
    }
}
