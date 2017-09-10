package com.example.nestor.android_02_navigation;

import android.content.Intent;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Toast;


public class MainActivity extends AppCompatActivity {

    public static final int EMAIL_REQUEST = 1000;
    public static final String EMAIL_KEY = "email_key";
    public static final String NAME_KEY = "name_key";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        //Get reference to floating button and set actions
        FloatingActionButton fab = (FloatingActionButton) findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view) {

                //Create a new intent
                Intent intent = new Intent(MainActivity.this, EmailListActivity.class);
                //Add information to intent
                intent.putExtra(NAME_KEY, "Ness Bautista");
                intent.putExtra(EMAIL_KEY, "ness@xyz.com");
                startActivityForResult(intent, EMAIL_REQUEST);
            }
        });
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        if (requestCode == EMAIL_REQUEST && resultCode == RESULT_OK)
        {
            String nameTxt = data.getStringExtra(NAME_KEY);
            String emailTxt = data.getStringExtra(EMAIL_KEY);
            Toast.makeText(this, "You entered: "+nameTxt+" and "+emailTxt, Toast.LENGTH_SHORT).show();
        }
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    public void displayStarters(View view)
    {
        Intent intent = new Intent(this, StartersActivity.class);
        startActivity(intent);
    }
}
