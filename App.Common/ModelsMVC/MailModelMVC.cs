using System;
using App.Common.PhoneInfraServices;

namespace App.Common.ModelMVC
{
	public class MailModelMVC
	{
			IPhoneService phone;

			public MailModelMVC (IPhoneService phone)
			{
				this.phone = phone;

				Init ();
			}

			public string FirstName {
				get;
				set;
			}

			public string LastName {
				get;
				set;
			}

			public string ZipCode {
				get;
				set;
			}

			public string Phone {
				get;
				set;
			}

			public string Explain {
				get {
					return string.Format(@"N'oublier pas de saisir vos coordonnées afin de faciliter la prise en charge de votre demande");
				}
			}

			public string Message {
				get;
				set;
			}


			void Init ()
			{
				Phone = phone == null ? null : phone.Number;
			}
		}
	}


