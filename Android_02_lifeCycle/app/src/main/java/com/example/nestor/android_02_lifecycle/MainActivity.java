package com.example.nestor.android_02_lifecycle;

import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.text.method.ScrollingMovementMethod;
import android.view.View;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.TextView;
import android.util.Log;
import android.text.Layout;

public class MainActivity extends AppCompatActivity {

    private TextView mLog;
    private static final String TAG = "MainActivity";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        //Get TextView
        mLog = (TextView) findViewById(R.id.log);
        mLog.setMovementMethod(new ScrollingMovementMethod());
        mLog.setText("");
        logMessage("READY");
        logMessage("onCreate");
    }

    @Override
    protected void onPause() {
        super.onPause();
        logMessage("onPause");
    }

    @Override
    protected void onResume() {
        super.onResume();
        logMessage("onResume");
    }

    @Override
    protected void onStop() {
        super.onStop();
        logMessage("onStop");
    }

    @Override
    protected void onStart() {
        super.onStart();
        logMessage("onStart");
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

    private void logMessage(String message)
    {
        //Output message to console
        Log.i(TAG, message);

        //Output message to textView
        mLog.append(message +"\n");

        //Adjust scroll position to make last line visible
        Layout layout = mLog.getLayout();
        if (layout != null) {
            int scrollAmount = layout.getLineTop(mLog.getLineCount()) - mLog.getHeight();
            mLog.scrollTo(0, scrollAmount > 0 ? scrollAmount : 0);
        }
    }
}
