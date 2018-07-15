using Android.App;
using Android.Widget;
using Android.OS;
using Android.Media;
using Android.Graphics;
using Android.Content;

namespace Android_1
{
    [Activity(Label = "Android_1", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private NotificationManager notification;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var b1 = FindViewById<Button>(Resource.Id.button1);
            var b2= FindViewById<Button>(Resource.Id.button2);

            notification = (NotificationManager)GetSystemService(NotificationService);

            b1.Click += delegate
            {
                //设置通知的图标以及显示的简介Title
                Notification notify = new Notification(Resource.Drawable.Icon, "普通通知");
                //初始化点击通知后打开的活动，我们点击通知之后都会打开对应的活动，所以我们需要初始化一个延迟意图，以便通知可以打开
                PendingIntent pintent = PendingIntent.GetActivity(this, 0, new Intent(this, typeof(MainActivity)), PendingIntentFlags.UpdateCurrent);
                //设置通知的主体
                notify.SetLatestEventInfo(this, "通知李白", "你二级没过", pintent);
                //发送通知
                notification.Notify(0, notify);//0为该通知的ID，方便后面接收该通知
            };

            b2.Click += delegate
            {
                Notification notify = new Notification(Resource.Drawable.Icon, "带有声音、LED光和震动的通知");
                //设置该通知具有声音、LED光和震动,即所有
                notify.Defaults = NotificationDefaults.All;

                //获取系统默认的通知声音
                Android.Net.Uri ringUri = RingtoneManager.GetDefaultUri(RingtoneType.Notification);
                //设置通知的声音
                notify.Sound = ringUri;

                //设置一秒的震动
                notify.Vibrate = new long[] { 1000 };
                //设置LED的颜色为绿色
                notify.LedARGB = Color.Green;
                //设置LED显示时间为1s
                notify.LedOnMS = 1000;
                //设置LED熄灭时间为1s
                notify.LedOffMS = 1000;
                //设置标志位，否则无法显示LED
                notify.Flags = NotificationFlags.ShowLights | notify.Flags;

                PendingIntent pintent = PendingIntent.GetActivity(this, 0, new Intent(this, typeof(MainActivity)), 0);

                notify.SetLatestEventInfo(this, "通知璐璐", "回来吃饺子", pintent);

                notification.Notify(1, notify);

            };
        }


    }
}

