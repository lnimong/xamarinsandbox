using System;
using App.Common.PhoneInfraServices;
using Android.Telephony;
using Android.Content;
using Android.App;

namespace Android02
{
	public class PhoneService : IPhoneService
	{
		Activity ctx;

		public PhoneService (Activity  ctx)
		{
			this.ctx = ctx;
		}

		public string Number {
			get {
				string number = null;
				string service = Context.TelephonyService;
				TelephonyManager tel_manager = (TelephonyManager)ctx.GetSystemService (service);
				var device_type = tel_manager.PhoneType;

				number = tel_manager.Line1Number;

				return number;
			}
		}
	}
}

