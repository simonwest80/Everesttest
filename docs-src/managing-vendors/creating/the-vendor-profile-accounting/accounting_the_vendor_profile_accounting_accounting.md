---
title: The Vendor Profile - Accounting (Accounting)
---

# The Vendor Profile - Accounting (Accounting)


**Federal ID Number**
: Enter the vendor's Federal ID Number using 1 to 40 characters of any type.
: ![]({{site.mv_baseurl}}/img/lens.gif)[Federal ID Number and 1099 Vendor]({{site.mv_baseurl}}/vendor-details/accounting-information/federal_id_number_and_1099_vendor_accounting_information.html)


**1099 Vendor**
: Select this check box if the vendor is a 1099 vendor.
: ![]({{site.mv_baseurl}}/img/lens.gif)[Federal ID Number and 1099 Vendor]({{site.mv_baseurl}}/vendor-details/accounting-information/federal_id_number_and_1099_vendor_accounting_information.html)


**Remit to Address**
: Click this button to enter Vender Remit to Address window.
: ![]({{site.mv_baseurl}}/img/lens.gif)[Remit to Address]({{site.mv_baseurl}}/vendor-details/accounting-information/account_the_vendor_profile_accounting_remit.html)


**Vendor Class**
: Specify the class to which the vendor belongs. Vendor  classes are created for tax purposes for different types of suppliers  and special tax rules can be defined for the vendor classes.
: ![]({{site.mv_baseurl}}/img/lens.gif) [Create  a Vendor Class]({{site.sc_chm}}/options/sales-tax/class/vendor-class/create_a_vendor_class.html)


**Posting Account Preferences**
: Specify an account selection methodology to be used  for the **Vendor** profile. You can  specify accounts without setting up posting groups. If you prefer to use  posting groups (groups of accounts), instead of making individual account  selections, that option is also available.

- **Use 
 Accounts Based Upon Hierarchy** ?Select this option if you would  like the system to use vendor control accounts at the location level first  (if defined) and then at the company level (accounting defaults).
- **Use 
 Posting Groups** ?Select this option if you would like to use Posting  Groups to define your accounts. If you select this option, you must enter  a “Vendor Posting Group?in the **Posting 
 Group** field that appears when you make this selection.
- **Specify 
 Accounts** ?Select this option if you would like to specify the  vendor control accounts to use for this Vendor. Click the ![]({{site.mv_baseurl}}/img/look_up_button_mv.gif)  lookup  button to view the related accounts that can be defined (see the following  figure). On the **Accounts** screen,  select the **Vendor Control** **Accounts** that you would like to define  for this Vendor. Click **Apply** and  then click **OK** to apply your selections.  
Click the following link for detailed information on the accounts:



![]({{site.mv_baseurl}}/img/lens.gif) [Accounts  Screen (Vendor)]({{site.mv_baseurl}}/misc/accounts_screen_vendor_profile_accounting_mv.html)


**Expense Account**
: Specify the default expense account to be debited  when a manual purchase journal is created for this vendor. A line entry  is automatically added with this default account.


![]({{site.mv_baseurl}}/img/example.gif)  If  you select the expense account for photocopying service in the **Vendor**  profile, when you create a manual purchase journal, it saves you data  entry as the account for this service is automatically displayed.


**Default Tax Code**
: Select a tax code that you want to apply to all  purchases from the vendor.


{:.note}
This tax code is applied only if no special tax rules exist for:

- The vendor and  item category combination
- The item that you  purchase from the vendor
- The item category  to which the item belongs
: ![]({{site.mv_baseurl}}/img/lens.gif) [Tax  Code]({{site.sc_chm}}/options/sales-tax/set-up-tax-codes-and-components/tax-code/tax_codes.html)


**Payment Terms**
: Specify the payment terms for the vendor. This is  a mandatory field. By default this field displays the payment term specified  in the **Vendors** dialog box (path:  **File** > **Setup**  > **Preferences** > **Defaults**  > **Vendors**).
: ![]({{site.mv_baseurl}}/img/lens.gif) [Payment  Terms]({{site.mv_baseurl}}/vendor-details/accounting-information/payment_terms_accounting_information_vendors_content.html)


**Calculate due date using purchase invoice date**
: Select this check box to calculate the due date  from the date of creation of the purchase invoice. If you do not select  this option, the due date is calculated based on the date in the vendor’s  invoice.


**Account Number assigned by Vendor**
: Enter the account number assigned by the vendor;  this may contain any type of character but may not exceed 20 characters.  The number helps identify a particular account when you have more than  one account with the vendor and also when reconciling the vendor's statement  of your account. This number, if available, appears on all check stubs  you print for the vendor for this account that do not include "Date  Printed" details.
: ![]({{site.mv_baseurl}}/img/lens.gif) [Account  Number Assigned by Vendor]({{site.mv_baseurl}}/vendor-details/accounting-information/account_number_assigned_by_vendor_accounting_information_vendors_content.html)


**Credit Limit**
: Enter the credit limit allowed by the vendor. You  can enter a maximum of 15 integers and 3 decimals in the **Credit 
 Limit** field.


{:.note}
The **Credit Limit** field cannot  have a negative value and the last decimal is rounded off. The number  of decimals displayed depends on the number of decimal digits specified  in your settings:

- **Currency**  profile - path: **File &gt; Setup &gt; 
 Accounting &gt; Multi-Currency &gt; Currency**.
- **Regional 
 Settings Properties** dialog box - From the **Currency** tab in the regional settings. The regional settings can be modified  from the Control Panel of your operating system.
: ![]({{site.mv_baseurl}}/img/lens.gif) [Credit  Limit]({{site.mv_baseurl}}/vendor-details/accounting-information/credit_limit_accounting_information_vendors_content.html)


**On Credit Hold**
: Select this check box if the vendor has put you  on hold.


{:.see_also}
See also
: [The  Vendor Profile - Accounting]({{site.mv_baseurl}}/creating/the-vendor-profile-accounting/the_vendor_profile_accounting_tab.html)
