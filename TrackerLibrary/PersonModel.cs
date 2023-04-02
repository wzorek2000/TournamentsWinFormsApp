namespace TrackerLibrary
{
    /// <summary>
    /// Represents one person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The first name of the person
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Surname of the person
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Email address of the person
        /// </summary>
        public string EmailAddress { get; set; }
        
        /// <summary>
        /// Phone number of the person
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}