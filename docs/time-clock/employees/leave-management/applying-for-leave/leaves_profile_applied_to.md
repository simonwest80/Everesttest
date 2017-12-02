---
title: Leaves Profile - Submit for Approval
---

# The Leave Profile - Submit for Approval


The **Submit for Approval** tab  allows you to specify the person to whom you have to apply for leave.


**Primary Approver**
: Select the person to whom you have to submit the  leave application. This drop down field lists the employee that was selected  in the **Reporting To** field of the  **User** profile (path: **File**  > **Setup** > **Users**  > **Users**) and also the employees  with higher authority than the one selected in **Reporting 
 To** field. This field is mandatory.


{:.note}
If no value is specified for the **Reporting 
 To** field, the **Primary Approver**  field will be blank by default, and will list only those employees that  do not have any value selected in the **Reporting 
 To** field.


![]({{site.tc_baseurl}}/img/example.gif) Employee A **Reporting 
 To** field is blank


Employee  B reports to Employee C


Employee  C reports to Employee D


Employee  D **Reporting To** field is blank


Employee  E **Reporting To** field is blank


Therefore, if Employee A submits a leave request,  the **Primary Approver** and **Alternate**


**Approver**  drop down fields display only Employee D and Employee E (who too do not  have a


reporting manager- because it is assumed that  they are top level employees).


{:.warn}
In cases where the  **Reporting To**  field is blank, there is a risk that wrong persons can get selected i.e.  persons whose designation may be lower than that of the applicant, and  **Everest** cannot control it. So  the responsibility lies with the user to select the correct person in  these fields.
: Suppose only one employee in **Everest**   has the  **Reporting To** field blank, it indicates  that this employee has highest authority and all other employees report  to him directly or indirectly. In such a case, if this employee applies  for leave, in his **Leave Request**  profile, the **Primary Approver**  and **Alternate Approver** fields  will list all employees other than him.


{:.example}
**Employee A (Team Member 1) reports to Employee  B**


**Employee  B  (Team  Lead 1) reports to Employee C**


**Employee  C  (Project  Lead 1) reports to Employee D**


**Employee  D  (Project  Manager) reports to Employee E**


**Employee  E (Vice President) **Reporting To**  field is blank**


**So now, if the Employee E (Vice President)  applies for leave, then the Primary Approver and Alternate Approver will  be blank by default and the drop down fields will list all the other employees  in the company (i.e. A,B,C and D). Employee E may select any of these  employees to approve his leave.  Usually  in most of the organizations, the HR Manager or the next highest employee  will be selected to approve the leave.**
: Suppose the person whom you report to goes on leave,  the leave will remain unapproved till another person is specifically selected  as the Reporting manager or a user with adequate security right approves  it.


{:.example}
**Employee A reports to Employee B**


**Employee  B reports to Employee C**


**Employee  C reports to Employee D**


**So, Employee B is the reporting manager of  Employee A. If Employee A applies for a leave request to Employee B who  is already on leave, either the Employee C or D can be made Reporting  manager of Employee A  (in  the user profile of  Employee  A) or they can be given security right  to  approve the applied leave.**


**Alternate Approver**
: Specify the name of the individual to whom a copy  of the leave application must be submitted. This drop down field lists  the employees that were selected in **Reporting 
 To** field of the **User** profile.  By default, this field will be blank.


**Notes**
: Enter any relevant note/information/comments.


**![]({{site.tc_baseurl}}/img/example.gif) Reason for leave.**


{:.note}
On migration of existing user details , note  the following:

- The **Reporting 
 To** field will be blank, if any cyclical references persist in the  **Reporting To** structure..
- The **Reporting 
 To** field will be blanked out, if any employee selected in the **Reporting To** field is discontinued.
- The **Primary 
 Approver** and **Alternate Approver**  fields will be blanked out, if the employee selected as the Reporting  Manager in the **User** profile is  no longer a part of the reporting chain.


{:.see_also}
See also
: [The Leave Request  Profile]({{site.tc_baseurl}}/misc/the_leave_profile.html)
