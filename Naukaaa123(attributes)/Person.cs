using System.ComponentModel;

public class Person 
{
    [PersonAttribute("First Name")] // sama as: [DisplayName("Last Name")] in ASP
    [DisplayName("First Person Name")]
    public string FirstName {get; set; }

    [PersonAttribute("Last Name")]
    [DisplayName("Last Person Name")]
    public string LastName {get; set; }
}