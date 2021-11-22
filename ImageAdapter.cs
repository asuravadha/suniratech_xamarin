using Android.Content;
using Android.Views;
using Android.Widget;

public class ImageAdapter : BaseAdapter
{
    Context context;

    public ImageAdapter(Context context)
    {
        this.context = context;
    }
   
    public override int Count { 
        get {
            return images.Length;
                } 
    }
    public override long GetItemId(int position) {
        return 0;
    }

    public override Java.Lang.Object GetItem(int position)
    {
        return null;
    }

    public override View GetView(int position, View convertView, ViewGroup parent)
    {
        ImageView imageView;
        if (convertView == null)
        {
            imageView=new ImageView(context);
            imageView.LayoutParameters = new GridView.LayoutParams(100, 100);
            imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
        }
        
        else
        {
            imageView = (ImageView)convertView;
        }
        imageView.SetImageResource(images[position]);
        return imageView;
}

    int[] images =
    {
    Resource.Drawable.b,Resource.Drawable.b,Resource.Drawable.b,Resource.Drawable.b,
};
}