// See https://aka.ms/new-console-template for more information

namespace businessclasses 
{
    class Patient 
    {

        private int patientID;
        private int accountID;
        private string patientFirstName; 
        private string patientMiddleName;
        private string patientLastName;
        private string patientStreet;
        private string patientCity;
        private string patientState; 
        private string patientZIP;
        private string patientPrimaryPhone;
        private string patientSecondaryPhone;
        private string patientSSN;
        private DateTime patientDOB;
        private boolean isMinor; 
        private int patientHeadOfHouse;
        private string[] patientAllergies;
       
        public Patient(int patientID, int accountID, string patientFirstName, string patientMiddleName, string patientLastName, string patientStreet, string patientCity, string patientState, string patientZIP, string patientPrimaryPhone, string patientSecondaryPhone, string patientSSN, DateTime patientDOB, boolean isMinor, int patientHeadOfHouse, string[] patientAllergies) 
        {
            this.patientID = patientID;
            this.accountID = accountID;
            this.patientFirstName = patientFirstName;
            this.patientMiddleName = patientMiddleName;
            this.patientLastName = patientLastName;
            this.patientStreet = patientStreet;
            this.patientCity = patientCity;
            this.patientState = patientState;
            this.patientZIP = patientZIP;
            this.patientPrimaryPhone = patientPrimaryPhone;
            this.patientSecondaryPhone = patientSecondaryPhone;
            this.patientSSN = patientSSN;
            this.patientDOB = patientDOB;
            this.isMinor = isMinor;
            this.patientHeadOfHouse = patientHeadOfHouse;
            this.patientAllergies = patientAllergies;
        }

        public int patientID 
        {
            get 
            {
                return this.patientID;
            }
            set 
            {
                this.patientID = value; 
            }
        }

        public int accountID
        {
            get 
            {
                return this.accountID;
            }
            set
            {
                this.accountID = value; 
            }
        }

        public string patientFirstName
        {
            get
            {
                return this.patientFirstNam;
            }
            set
            {
                this.patientFirstName = value; 
            }
        }

        public string patientMiddleName
        {
            get
            {
                return this.patientMiddleName;
            }
            set
            {
                this.patientMiddleName = value;
            }
        }

        public string patientLastName
        {
            get
            {
                return this.patientLastName;
            }
            set
            {
                this.patientLastName = value; 
            }
        }

        public string patientStreet
        {
            get
            {
                return this.patientStreet;
            }
            set
            {
                this.patientStreet = value;
            }
        }

        public string patientCity
        {
            get
            {
                return this.patientCity;
            }
            set
            {
                this.patientCity = value;
            }
        }

        public string patientState
        {
            get
            {
                return this.patientState;
            }
            set
            {
                this.patientState = value; 
            }
        }
        
        public string patientZIP
        {
            get
            {
                return this.patientZIP;
            }
            set
            {
                this.patientZIP = value;
            }
        }

        public string patientPrimaryPhone
        {
            get
            {
                return this.patientPrimaryPhone;
            }
            set
            {
                this.patientPrimaryPhone = value;
            }
        }

        public string patientSecondaryPhone
        {
            get
            {
                return this.patientSecondaryPhone;
            }
            set
            {
                this.patientSecondaryPhone = value;
            }
        }

        public string patientSSN
        {
            get
            {
                return this.patientSSN;
            }
            set
            {
                this.patientSSN = value;
            }
        }

        public DateTime patientDOB
        {
            get
            {
                return this.patientDOB;
            }
            set
            {
                this.patientDOB = value;
            }
        }

        public boolean isMinor
        {
            get
            {
                return this.isMinor;
            }
            set
            {
                this.isMinor = value;
            }
        }

        public int patientHeadOfHouse
        {
            get
            {
                return this.patientHeadOfHouse;
            }
            set
            {
                this.patientHeadOfHouse = value;
            }
        }

        public string[] patientAllergies
        {
            get
            {
                return this.patientAllergies;
            }
            set
            {
                this.patientAllergies = value;
            }
        }
    }
}
