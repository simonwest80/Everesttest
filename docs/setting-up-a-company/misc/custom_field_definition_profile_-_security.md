---
title: Custom Field Definition Profile - Security
---

# Custom Field Definition Profile - Security


Use the **Security** tab to assign  **Add New Value** security right and  **Modify Value** security right for  adding/modifying values in that respective **Custom**  field. With **Add New Value** security  right, you can add new value to that **Custom**  field and use the **Modify Value**  security right to modify the existing value present in that **Custom**  field. You can assign rights either to a Group or to individual Users.  Once you have assigned rights to the groups or users, the result will  be reflected in the **Security Rights**  browser (path: **File** > **Setup** > **Security 
 Rights**).


{:.note}
You can change **Custom**  field security rights from the **Security 
 Rights** browser also.


**Add New Value - Security Description**
: This field displays the security right to add a  new value to a custom field in a specified format. The **Custom**  field for which you are assigning the **Add 
 New Value** right is automatically populated in this field.


{:.example}
If you are assigning a security right to add a new value to the custom  field, CUSTCHAR 1, for which the field description is Primary Vendor,  the security right is displayed as below:


Custom Field: Primary Vendor: Add New Value


{:.note}
You cannot edit this field because it is read-only.


**Modify New Value - Security Description**
: This field displays the security right to edit an  existing value for a custom field in a specified format. The **Custom**  field for which you are assigning the **Modify 
 Value** right is automatically populated in this field.


{:.example}
If you are assigning a security right to edit a value for the custom  field, CUSTCHAR 1, for which the field description is Primary Vendor,  the security right is displayed as below:


Custom Field: Primary Vendor: Modify Value


{:.note}
You cannot edit this field because it is read-only.


**Groups**
: Click this button to display all the groups defined  in the Groups browser (path: **File**  > **Setup** > **Users**  > **Groups**) in the grid below.  By default, this button is disabled indicating that the button is selected.


**Users**
: On clicking this button all the users set up in  the Users browser (path: **File**  > **Setup** > **Users**  > **Groups**) are displayed in  the grid below. Clicking this button disables it indicating the selection  of this button.


Assign Security Rights Grid
: Use this grid to assign the **Add 
 New Value** and **Modify Value**  security rights to users or groups.  You  can also search based upon the User/Group code and Description.


{:.note}
If you assign the **Modify 
 Value** right to a user or group, by default the **Add 
 New Value** right is assigned to the respective user or group.


**Add New**
: Select the check box to allow the user/group with  rights to add new values for the custom fields. You can sort this column.


**Modify**
: Select the check box to allow the user/group with  rights to both add new value and edit the existing values of the custom  fields. You can sort this column.


**User Code/Group Code**
: Fills in User/Group codes based upon the codes that  have already been created for them in the **Security 
 Rights** browser (path: **File**  > **Setup** > **Security 
 Rights**). You can sort this column.


**User Description/Group Description**
: Fills in User/Group description based upon the description  that has already been created for them in the **Security 
 Rights** browser (path: **File**  > **Setup** > **Security 
 Rights**). You can sort this column.


{:.see_also}
See also
: [Custom  Field Definition Profile]({{site.sc_baseurl}}/options/miscellaneous-set-up/custom-fields/custom-field-definition-profile/custom_field_definition_profile.html)
: [Custom  Field Definition Profile - General]({{site.sc_baseurl}}/misc/custom_field_definition_profile_-_general.html)
