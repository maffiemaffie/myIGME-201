using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohen_UT2_04_07
{
    static internal class Program
    {
        static void Main(string[] args)
        {
            Tardis tardis = new Tardis();
            PhoneBooth phoneBooth = new PhoneBooth();

            UsePhone(tardis);
            UsePhone(phoneBooth);
        }

        static void UsePhone(object obj)
        {
            if (obj.GetType() == typeof(Tardis))
            {
                Tardis tardis = (Tardis) obj;
                tardis.TimeTravel();
                return;
            }
            if (obj.GetType() == typeof(PhoneBooth))
            {
                PhoneBooth phoneBooth = (PhoneBooth) obj;
                phoneBooth.OpenDoor();
                return;
            }
        }

        public abstract class Phone
        {
            private string phoneNumber;
            public string address;

            public string PhoneNumber
            {
                get { return phoneNumber; }
                set { phoneNumber = value; }
            }

            public abstract void Connect();
            public abstract void Disconnect();
        }

        public interface IPhoneInterface
        {
            void Answer();
            void MakeCall();
            void HangUp();
        }

        public class RotaryPhone : Phone, IPhoneInterface
        {
            public void Answer() { }
            public void MakeCall() { }
            public void HangUp() { }
            public override void Connect() { }
            public override void Disconnect() { }
        }

        public class PushButtonPhone : Phone, IPhoneInterface
        {
            public void Answer() { }
            public void MakeCall() { }
            public void HangUp() { }
            public override void Connect() { }
            public override void Disconnect() { }
        }

        public class Tardis : RotaryPhone
        {
            private bool sonicScrewdriver;
            private byte whichDrWho;
            private string femaleSideKick;
            public double exteriorSurfaceArea;
            public double interiorVolume;

            public byte WhichDrWho
            {
                get { return whichDrWho; }
            }
            public string FemaleSideKick
            {
                get { return femaleSideKick; }
            }

            public void TimeTravel() { }

            public static bool operator ==(Tardis left, Tardis right) => left.whichDrWho == right.whichDrWho;
            public static bool operator !=(Tardis left, Tardis right) => left.whichDrWho != right.whichDrWho;
            public static bool operator <(Tardis left, Tardis right) => left.whichDrWho != 10 && right.whichDrWho == 10 || left.whichDrWho < right.whichDrWho;
            public static bool operator >(Tardis left, Tardis right) => left.whichDrWho == 10 && right.whichDrWho != 10 || left.whichDrWho > right.whichDrWho;
            public static bool operator <=(Tardis left, Tardis right) => right.whichDrWho == 10 || left.whichDrWho <= right.whichDrWho;
            public static bool operator >=(Tardis left, Tardis right) => left.whichDrWho == 10 || left.whichDrWho <= right.whichDrWho;
        }

        public class PhoneBooth : PushButtonPhone
        {
            private bool superMan;
            public double costPerCall;
            public bool phoneBook;

            public void OpenDoor() { }
            public void CloseDoor() { }
        }
    }
}
