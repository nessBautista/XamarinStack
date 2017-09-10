package com.example.nestor.android_03_listviews;

import android.content.Context;
import android.content.res.AssetManager;
import android.graphics.BitmapFactory;
import android.support.annotation.LayoutRes;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import java.io.IOException;
import java.io.InputStream;
import java.text.NumberFormat;
import java.util.List;
import android.graphics.Bitmap;
/**
 * Created by Nestor on 9/9/17.
 */

public class ProductListAdapter extends ArrayAdapter<Product> {

    private List<Product> products;

    public ProductListAdapter(@NonNull Context context, @LayoutRes int resource, @NonNull List<Product> objects) {
        super(context, resource, objects);
        products = objects;
    }

    @NonNull
    @Override
    public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {

        //Fill cells
        if (convertView == null)
        {
            convertView = LayoutInflater.from(getContext()).inflate(R.layout.list_item, parent, false);
        }

        Product product = products.get(position);

        TextView nameText = (TextView) convertView.findViewById(R.id.nameText);
        nameText.setText(product.getName());

        NumberFormat formatter = NumberFormat.getCurrencyInstance();
        String price = formatter.format(product.getPrice());
        TextView priceText = (TextView) convertView.findViewById(R.id.priceText);
        priceText.setText(price);


        ImageView iv = (ImageView) convertView.findViewById(R.id.imageView);
        Bitmap bitmap = getBiptmapFromAsset(product.getProductId());
        iv.setImageBitmap(bitmap);

        return convertView;
    }

    private Bitmap getBiptmapFromAsset(String productId) {

        AssetManager assetManager = getContext().getAssets();
        InputStream stream = null;
        try {
            stream = assetManager.open(productId+".png");
            return BitmapFactory.decodeStream(stream);
        } catch (IOException e) {
            e.printStackTrace();
            return null;
        }
    }
}
