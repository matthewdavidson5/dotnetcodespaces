// See https://aka.ms/new-console-template for more information

namespace businessclasses {

    class Patient {

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
       
        public Patient(int patientID, int accountID, string patientFirstName, string patientMiddleName, string patientLastName, string patientStreet, string patientCity, string patientState, string patientZIP, string patientPrimaryPhone, string patientSecondaryPhone, string patientSSN, DateTime patientDOB, boolean isMinor, int patientHeadOfHouse, string[] patientAllergies) {
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
    }
}
