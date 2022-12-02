//AUTHOR: Matthew Davidson, Josh Hill, Daniel Ortiz
//COURSE: ISTM 315.502
//CLASS: Patient
//PURPOSE: To serve as a container for patient information.
//HONOR CODE: “On my honor, as an Aggie, I have neither given 
// nor received unauthorized aid on this academic 
// work.”

namespace businessclasses 
{
    public class Patient 
    {

        //private fields
        private int intPatientID;
        private int intAccountID;
        private string strPatientFirstName; 
        private string strPatientMiddleName;
        private string strPatientLastName;
        private string strPatientStreet;
        private string strPatientCity;
        private string strPatientState; 
        private string strPatientZIP;
        private string strPatientPrimaryPhone;
        private string strPatientSecondaryPhone;
        private string strPatientSSN;
        private DateTime dtPatientDOB;
        private bool boolIsMinor; 
        private int intPatientHeadOfHouse;
        private string[] strarrPatientAllergies;
       
        //Default constructor with no args
        public Patient() { }

        //Custom constructor for assigment upon init
        public Patient(int intPatientID, int intAccountID, string strPatientFirstName, string strPatientMiddleName, string strPatientLastName, string strPatientStreet, string strPatientCity, string strPatientState, string strPatientZIP, string strPatientPrimaryPhone, string strPatientSecondaryPhone, string strPatientSSN, DateTime dtPatientDOB, bool boolIsMinor, int intPatientHeadOfHouse, string[] strarrPatientAllergies) 
        {
            this.intPatientID = intPatientID;
            this.intAccountID = intAccountID;
            this.strPatientFirstName = strPatientFirstName;
            this.strPatientMiddleName = strPatientMiddleName;
            this.strPatientLastName = strPatientLastName;
            this.strPatientStreet = strPatientStreet;
            this.strPatientCity = strPatientCity;
            this.strPatientState = strPatientState;
            this.strPatientZIP = strPatientZIP;
            this.strPatientPrimaryPhone = strPatientPrimaryPhone;
            this.strPatientSecondaryPhone = strPatientSecondaryPhone;
            this.strPatientSSN = strPatientSSN;
            this.dtPatientDOB = dtPatientDOB;
            this.boolIsMinor = boolIsMinor;
            this.intPatientHeadOfHouse = intPatientHeadOfHouse;
            this.strarrPatientAllergies = strarrPatientAllergies;
        }

        //Public properties to access private fields
        public int PatientID 
        {
            get 
            {
                return this.intPatientID;
            }
            set 
            {
                this.intPatientID = value; 
            }
        }

        public int AccountID
        {
            get 
            {
                return this.intAccountID;
            }
            set
            {
                this.intAccountID = value; 
            }
        }

        public string PatientFirstName
        {
            get
            {
                return this.strPatientFirstName;
            }
            set
            {
                this.strPatientFirstName = value; 
            }
        }

        public string PatientMiddleName
        {
            get
            {
                return this.strPatientMiddleName;
            }
            set
            {
                this.strPatientMiddleName = value;
            }
        }

        public string PatientLastName
        {
            get
            {
                return this.strPatientLastName;
            }
            set
            {
                this.strPatientLastName = value; 
            }
        }

        public string PatientStreet
        {
            get
            {
                return this.strPatientStreet;
            }
            set
            {
                this.strPatientStreet = value;
            }
        }

        public string PatientCity
        {
            get
            {
                return this.strPatientCity;
            }
            set
            {
                this.strPatientCity = value;
            }
        }

        public string PatientState
        {
            get
            {
                return this.strPatientState;
            }
            set
            {
                this.strPatientState = value; 
            }
        }
        
        public string PatientZIP
        {
            get
            {
                return this.strPatientZIP;
            }
            set
            {
                this.strPatientZIP = value;
            }
        }

        public string PatientPrimaryPhone
        {
            get
            {
                return this.strPatientPrimaryPhone;
            }
            set
            {
                this.strPatientPrimaryPhone = value;
            }
        }

        public string PatientSecondaryPhone
        {
            get
            {
                return this.strPatientSecondaryPhone;
            }
            set
            {
                this.strPatientSecondaryPhone = value;
            }
        }

        public string PatientSSN
        {
            get
            {
                return this.strPatientSSN;
            }
            set
            {
                this.strPatientSSN = value;
            }
        }

        public DateTime PatientDOB
        {
            get
            {
                return this.dtPatientDOB;
            }
            set
            {
                this.dtPatientDOB = value;
            }
        }

        public bool IsMinor
        {
            get
            {
                return this.boolIsMinor;
            }
            set
            {
                this.boolIsMinor = value;
            }
        }

        public int PatientHeadOfHouse
        {
            get
            {
                return this.intPatientHeadOfHouse;
            }
            set
            {
                this.intPatientHeadOfHouse = value;
            }
        }

        public string[] PatientAllergies
        {
            get
            {
                return this.strarrPatientAllergies;
            }
            set
            {
                this.strarrPatientAllergies = value;
            }
        }

        /* public static void Main(string[] args) {
        
        } */
    }
}
