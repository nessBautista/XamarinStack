package com.example.nestor.android_03_listviews;

import android.content.Intent;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.CoordinatorLayout;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;

import java.util.List;

public class MainActivity extends AppCompatActivity {

    public static final String PRODUCT_ID = "PRODUCT_ID";
    private static final int DETAIL_REQUEST = 1111;
    public static final String RETURN_MESSAGE = "RETURN_MESSAGE";
    private CoordinatorLayout coordinatorLayout;
    private List<Product> products = DataProvider.productList;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        coordinatorLayout = (CoordinatorLayout) findViewById(R.id.coordinator);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        FloatingActionButton fab = (FloatingActionButton) findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });

        String[] items = getResources().getStringArray(R.array.clothing);
        //ArrayAdapter<String> adapter= new ArrayAdapter<String>(this,
        //        android.R.layout.simple_list_item_1,
        //        android.R.id.text1, items);

        ProductListAdapter adapter = new ProductListAdapter(this, R.layout.list_item, products);
        ListView lv = (ListView) findViewById(R.id.listView);
        lv.setAdapter(adapter);

        //ON ITEM SELECTED
        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int position, long id) {

                Intent intent = new Intent(MainActivity.this, DetailActivity.class);
                //Pass data
                Product product = products.get(position);
                intent.putExtra(PRODUCT_ID, product.getProductId());

                //Show activity
                startActivityForResult(intent, DETAIL_REQUEST);
            }
        });
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

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {

        if (requestCode == DETAIL_REQUEST ) {
            if(resultCode == RESULT_OK) {

                String message = data.getStringExtra(RETURN_MESSAGE);
                Snackbar.make(coordinatorLayout, message, Snackbar.LENGTH_LONG).setAction("Go to cart", new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        Toast.makeText(MainActivity.this, "Going to cart", Toast.LENGTH_SHORT).show();
                    }
                }).show();
            }
        }
    }
}
