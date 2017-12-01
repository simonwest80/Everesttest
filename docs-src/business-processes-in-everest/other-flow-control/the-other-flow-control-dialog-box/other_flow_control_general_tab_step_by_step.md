---
title: Other Flow Control - General
---

# Other Flow Control - General


**Prompt user with Document Printing Preferences  Profile before printing a document**
: Select this check box to be prompted with the **Printing** **Preferences**  dialog box before you print a document.
: ![]({{site.bp_baseurl}}/img/lens.gif) [Printing  Preferences Dialog Box]({{site.bp_baseurl}}/rpt-prt/set-prt/the_printing_preferences_dialog_box_step_by_step_bp.html)


**Allow user to clock in/out across days**
: Select this check box if you want the user to clock  in/out across days other than the current date.


![]({{site.bp_baseurl}}/img/example.gif)  A  user could clock in on April 12th and clock out on April 13th.


**Enable global password mode at login**
: Select this check box to enable the global password  at login. Whenever a user logs into **Everest**  the user can perform all functions for which access has been granted without  having to re-enter the password.


![]({{site.bp_baseurl}}/img/lens.gif) [Global  Password On/Off]({{site.sc_chm}}/options/security/passwords/global_password_on_off.html)


**Allow user to post a journal even if it is not  printed**
: Check this box to post journals to the relevant  ledger accounts, even if these journals have not been printed.


{:.hint}
It is recommended that all journals be printed  before posting for audit purposes.


![]({{site.bp_baseurl}}/img/lens.gif)  [Posting]({{site.acc_chm}}/accounting-structure-in-everest/posting/posting.html)


**Automatically popup customer tracking when creating  a new customer**
: Select this check box to automatically popup the  customer tracking browser when you create a new customer.


![]({{site.bp_baseurl}}/img/example.gif)  This  feature can be used to force tagging of customers by ‘How the customer  found us’ when a new customer is created, and acts as a reminder to use  the tracking feature.


**Automatically popup vendor tracking when creating  a new vendor**
: Select this check box to automatically display the  vendor tracking browser when you create a new vendor. This browser will  be displayed when you save information for the new **Vendor**  profile.


**Copy files to Global Multimedia Repository**
: Select this option to copy files to the **Global 
 Multimedia Repository**, **** which  is a global directory in which multimedia files are copied. Files will  be copied to the global repository only if you have specified the global  multimedia repository path in the default preferences (path: **File 
 &gt; Setup &gt; Preferences &gt; Defaults &gt; Other Defaults**).


**Prompt user if an appointment conflicts with  an existing appointment**
: Select this check box to prompt the user if an appointment  conflicts with an existing appointment. If this option is left unchecked,  you can create more than one appointment at the same instance.


{:.note}
If there is a conflict with an existing appointment  and this option is selected, you will be informed that there is a conflict  with an existing appointment and will be asked whether you want to retain  the existing time schedule.

- Click **Yes** to create the appointment.
- Click **No** if you want to reschedule the appointment.


**Automatically check for reminders every \_ seconds**
: You can display reminders for tasks and appointments.  Select this check box if you want **Everest**  to automatically check for reminders and specify the frequency for checking  reminders. If this check box is not selected, reminders are NOT displayed.
: The value in the **Automatically 
 check for reminders every** field on the **Workstation 
 Settings** dialog box (path: **File 
 &gt; Setup &gt; Preferences &gt; Workstation Settings &gt; General &gt; 
 Others** tab) defaults to the value specified here. Since this setting  is applicable at the company wide level, deselecting  this box will allow **Everest** to  load faster. If you deselect  this checkbox, the reminder preference in the **Workstation 
 Settings** dialog box cannot be selected.


{:.note}
: You can specify a maximum value of 999 in this field.


**Enter the maximum number of records that can  be fetched through get more function in the browsers without security  check**
: Enter the maximum number of records that can be  retrieved into a browser by clicking the "Get" button. If more  records have to be retrieved at a time into the browser, the user must  have appropriate security rights.
: ![]({{site.bp_baseurl}}/img/example.gif)  If  100 is specified in this field, you can get only 100 records at a time  into any browser. If you need to retrieve more than 100 records at a time,  the "Get records above threshold limit in a browser" right must  also be assigned to you.


**Allow users to access stock bins of**
: Select **Logged in 
 Location** option from this drop down field to assign/access stock  bins that belong to the login location or select **All 
 Locations** option to assign/access stock bins of all locations.


{:.note}
If you select **Logged 
 in Location** from **Allow users to 
 access stock bins of** drop down field (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Other 
 Flow Control**) **Specific location**  option will automatically get selected in the **View**  drop down field in **Attach Quantity**  dialog box and **Retrieve Serial Numbers**  dialog box. The **Location** drop  down field will have locations pertaining to the logged in location.


If you select **All 
 Locations** option from **Allow users 
 to access stock bins of** drop down field (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Other 
 Flow Control**) **All Locations**  option will automatically get selected in the **View**  drop down field in **Attach Quantity**  dialog box and **Retrieve Serial Numbers**  dialog box. Also, an extra **Location**  column will get added in the grid of **Attach 
 Quantity** dialog box.


**Remove automated customer on hold automatically**
: Select this check box to remove automatic on credit  holds automatically. The conditions for automatic on credit holds are  set in the **Customer** profile –  **Payment Information** tab. If the  conditions are met, the system places an automatic on credit hold for  the customer. If you select this option and the customer no longer meets  the automatic on hold conditions, the system automatically removes the  automatic on credit hold. System checks for automatic credit hold removal  occur at the following times:

- Once per day at 12:00  AM
- Every time a payment/refund  or another financial change is made to the customer account



{:.example}
If the **Number 
 of days past due** is 15 days, the customer is put on hold automatically  after 15 days. If the customer makes the required payments according to  the payment terms after the automatic credit hold is placed and the **Remove automated customer on hold automatically**  option is selected, the system automatically removes the credit hold since  the account is current.
: If this option is not selected, the customer must  be manually removed from hold if the customer no longer meets the hold  conditions.
: ![]({{site.bp_baseurl}}/img/lens.gif)[The  Customer Profile - Payment Information Tab (Automated Hold Conditions)]({{site.mc_chm}}/creating-a-customer/the-customer-profile-payment-information/the_customer_profile_payment_information.html)


{:.see_also}
See also
: [The  Other Flow Control Dialog Box]({{site.bp_baseurl}}/other-flow-control/the-other-flow-control-dialog-box/other_flow_control_dialog_box_step_by_step.html)
