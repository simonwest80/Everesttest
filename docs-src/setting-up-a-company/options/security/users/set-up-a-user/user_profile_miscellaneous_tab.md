---
title: The User Profile - Miscellaneous
---

# The User Profile - Miscellaneous


Use the **Miscellaneous** tab to  specify details such as the location/sub-location to which the user belongs,  the designation and cash register that are assigned to the user. You can  also configure each user with a separate dashboard, depending upon your  Everest installation license


**Location/Sub-Location**
: If the company is classified by location, specify  the default location/sub-location in which the user works.


**Cash Register**
: Specify the default cash register that the user  is assigned. Whenever the user creates a POS invoice, this cash register  is selected by default.


**Designation**
: Specify the designation or the position of the user  in the company.
: ![]({{site.sc_baseurl}}/img/lens.gif) [Designations]({{site.tc_chm}}/employees/designations/designations.html)


**[]()Reporting To**
: Specify the employee to whom you are reporting to.  The employee you select here will appear as primary approver in the **Leave 
 Request** profile, when you apply for leave. The validations  for this field are mentioned below:

- Only active  employees will be listed here.
- Only employees  who do not report to the same employee or any other person, who reports  to this employee, will be listed in this drop down (i.e. cyclical reporting  structure should not be permitted).



{:.example}
: Employee A reports to Employee B
: Employee  B reports to Employee C
: Employee  C reports to Employee D
: In the **Reporting 
 To** drop down field of
: Employee D - List all employees other than Employee  A, B & C.
: Employee C - List all employees other than Employee  A & B.
: Employee B – List all employees other than Employee  A.
: Employee A - List all employees.


**Dashboard**
: Select the user’s default dashboard. This is the  dashboard that the user sees at login. Depending upon your Dashboard Analytics  license type, you can select one of the following possible values in the  table:


| Dashboard Field Values | What the User Sees | License Needed to View this Option |
| None | An Image Only – The toolbar is disabled | All licenses can view this option |
| Basic | Management Synopsis | Basic, Professional, and Enterprise |
| Professional | The Default Windows SharePoint Services site URL | Professional |
| Enterprise | The Default Windows SharePoint Services site URL | Enterprise |
| Custom | The URL entered in the User Profile – Miscellaneous  tab URL field | All licenses can view this option |

: For more information, refer to the **Everest 
 Advanced Edition Dashboard** User Guide.


**URL**
: If the Dashboard field is set to **Custom**,  enter a valid URL. Otherwise, this field shows the URL or path being used  for the user’s default dashboard.


**Show Pending Contact Manager Tasks during**
: Specify whether **Everest**  should display the pending contact manager tasks, if any, when the user  logs into the system and/or when the user exits the system.


Notes


**Note Information**
: Enter other information or notes concerning the  user.


**Gender**
: Select the gender of the user.


**Date of Birth**
: Select the date of birth of the user.


{:.see_also}
See also
: [Miscellaneous  information]({{site.sc_baseurl}}/options/security/users/user-details/miscellaneous_information_user_profile.html)
: [The **User**  Profile]({{site.sc_baseurl}}/options/security/users/set-up-a-user/the_user_profile.html)
: [Creating a new  user]({{site.sc_baseurl}}/options/security/users/set-up-a-user/creating_a_new_user.html)
