---
title: The Customer Profile - Payment information
---

# The Customer Profile - Payment Information


This tab allows you to enter payment details such as payment terms,  credit card details and credit limit for the customer.


Payment terms


{:.note}
- You must specify  at least one payment term for the customer.
- Payment terms in  this tab is defaulted based on the settings in the **Location**  preferences (path: **File** > **Setup** > **Accounting**  > **Location/Sub-location** >  **Customer** tab)
: ![]({{site.mc_baseurl}}/img/lens.gif) [Payment  Information]({{site.mc_baseurl}}/customer-details/payment-information/payment_information_content.html)


**Allow Prepay Purchases**
: Check this option if the customer is allowed to  make payments before the items are delivered. This field is selected by  default.


**Default credit card number**
: Select the default credit card number of the customer  from the drop-down list. The credit card number is displayed in an encrypted  format. Credit card numbers are masked using the format XXXXXXXXXXXX<last  four digits of the card> when the **Enable 
 Extended Mode** check box is cleared (path: **File 
 &gt; Setup &gt; Preferences &gt; Workstation Settings &gt; Company Settings**  tab). Click the **Add New Credit Card Details** lookup button ![]({{site.mc_baseurl}}/img/managing_customers_lookup_button.gif) beside this field to display the  **Credit Cards** browser. Here, you  can view credit card details, and create credit card accounts for the  customer.
: ![]({{site.mc_baseurl}}/img/note.gif)  Only  users with adequate security rights can access the **Credit 
 Cards** browser and **Credit Card** profile.
: The **Add 
 New Credit Card Details** button ![]({{site.mc_baseurl}}/img/managing_customers_lookup_button.gif) is disabled if the  **Automatically Save Credit Card to Account** option is unchecked.
: You can set up credit cards for a new  customer, and save the details, before you save the profile. Other customer  details such as account name and the first name or the last name continue  to be mandatory. If you decide not to create the customer, after specifying  and saving credit card details for this customer, these details are purged,  and are not available to any user.
: You can discontinue a credit card even  if it is set as the default for the customer.
: ![]({{site.mc_baseurl}}/img/lens.gif) [Credit  Card Information]({{site.mc_baseurl}}/customer-details/payment-information/credit_card_information_cust_profile.html)


**Automatically Save Credit Card to Account**
: Select this option to automatically add new credit  card details to the credit cards browser for this customer, after the  credit card verification process.
: The **Add New Credit 
 Card Details** lookup button ![]({{site.mc_baseurl}}/img/managing_customers_lookup_button.gif) in the **Payment****Information** tab of the **Customer**  profile is also enabled when you select this option.
: ![]({{site.mc_baseurl}}/img/note.gif)  You  can ensure that this field is checked, by default, when you create a customer,  by selecting the **Automatically Save Credit 
 Card Details** option in the **Customers**  tab (path: **File &gt; Setup &gt; Accounting 
 &gt; Location/Sub-Location**).


**Allow COD Purchases**
: Select this option to allow the customer to pay  cash when the items are delivered.
: ![]({{site.mc_baseurl}}/img/lens.gif) [Cash  on Delivery]({{site.mc_baseurl}}/misc/cash_on_delivery.html)


**Allow On Account Purchases**
: Select this option to allow the customer to make  purchases on credit wherein the payment is received after a fixed duration  from the delivery date.
: ![]({{site.mc_baseurl}}/img/lens.gif) [On Account]({{site.mc_baseurl}}/misc/on_account.html)


**Terms**
: Specify the ‘On account’  payment term applicable to the customer. This field is enabled only if  the **Allow** **On 
 Account Purchases** option is selected<font style="color: #000000;" color="#000000">.</font>
: ![]({{site.mc_baseurl}}/img/lens.gif) [Payment  Terms]({{site.sc_chm}}/options/payment-information/payment-terms/payment_terms.html)


**Sales Orders and Invoices with COD or On Account  terms require a PO#**
: Select this option to make entry of the customer's  PO reference number mandatory, when you select **COD/On 
 Account** terms (for the customer) on sales orders and invoices.  You can use this reference when following up on payments due.
: ![]({{site.mc_baseurl}}/img/note.gif)  You  can ensure that multiple sales orders and invoices are not created for  the same customer purchase order reference, by selecting the **Prompt 
 for the duplicate PO number from the same customer** option in the  **Documents** dialog box (path: **File &gt; Setup &gt; Preferences &gt; Flow 
 Control &gt; Documents &gt; Prompts &gt; Sales Document &gt; Sales Document 
 2** tab).
: If the **Customer’s 
 PO No**. field in the sales document is left blank, while saving  the document, **Everest** prompts  the user to enter the customer’s purchase order reference. The user must  have the relevant security rights assigned, to enter this reference in  sales documents.
: ![]({{site.mc_baseurl}}/img/lens.gif) [Cash  on Delivery]({{site.mc_baseurl}}/misc/cash_on_delivery.html)
: [On Account]({{site.mc_baseurl}}/misc/on_account.html)


Credit limits


![]({{site.mc_baseurl}}/img/lens.gif) [Credit Limits]({{site.mc_baseurl}}/customer-details/payment-information/credit_limits.html)


**On Credit Hold**


**![]({{site.mc_baseurl}}/img/manual_credit_hold_mc.gif)**


**Figure: Manual Credit Hold**
: Select this option to manually put the customer  on credit hold. Click the **Notes**  icon ![]({{site.mc_baseurl}}/img/managing_customers_notes_icon.gif) beside this field to specify reasons for putting  the customer on hold and to view the hold history. It shows if and when  a customer was manually put on hold, if and when the hold was removed,  and the person who performed the action. It also shows information on  automatic holds.


**On Credit Hold (Automatic)**


**![]({{site.mc_baseurl}}/img/automatic_credit_hold_mc.gif)**


**Figure: Automatic Credit Hold**
: If the customer is put on automatic credit hold,  this box shows the current status and **Everest**  adds comments, stating the reason for putting the customer on automatic  credit hold. You can view the comments by clicking the **Notes**  icon. Any existing notes are shown below the automatic credit hold note.


{:.note}
If you clear the **On 
 Credit Hold** check box manually, **Everest**  checks if the **Number of days past due**  check box and the **Amount Over Credit 
 Limit** check box are checked (path: **Invoicing**  > **Customers** > **Edit**  > **In New Window** > **Payment Information**). If either or both  of the boxes are checked, and the selected condition is met, the customer  continues to be on automatic credit hold. The automatic credit hold conditions  are checked whenever the Customer profile or a sales document belonging  to the customer is opened, or when the customer is selected in a document.


**Credit Limit**
: Enter the credit limit applicable to the customer.
: ![]({{site.mc_baseurl}}/img/note.gif)  The  **Credit Limit** field cannot have  a negative value. The number of decimals displayed in this field depends  on the number of decimal specified in your settings:

- **Currency** profile - path: **File 
 &gt; Setup &gt; Accounting &gt; Multicurrency 
 &gt; Currency &gt; Options &gt; Edit &gt; In New Window &gt; Decimals 
 to display** field.
- **Regional Settings Properties** dialog  box - From the Currency tab in the regional settings. You can modify the  regional settings from the Control Panel of your operating system.



Automated Hold Conditions


The automated hold conditions in this section can be set  to automatically place the customer on hold if the conditions are met.  Likewise, if the customer no longer meets the conditions specified, the  system can automatically remove the automatic credit hold if you select  the **Remove automated customer on hold 
 automatically** option in the **Other 
 Flow Control** dialog box (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Other 
 Flow Control** > **General**  tab).
: ![]({{site.mc_baseurl}}/img/lens.gif)[Other  Flow Control - General Tab]({{site.bp_chm}}/other-flow-control/the-other-flow-control-dialog-box/other_flow_control_general_tab_step_by_step.html)


**Number of days past due**
: The due date for payment is computed based on the  payment terms. Check this box to put the customer on automatic hold if  payment is not received even after the expiry  of the additional number of days (also called days past due) specified  here.
: Specify the number of days from the payment date  in the box below this field.


**Amount Over Credit Limit**
: Select this box to put the customer on automatic  hold if the amount due from the customer exceeds the credit limit plus  the amount over credit limit.
: Enter the amount over credit limit applicable to  the customer in the box below this field.


{:.see_also}
See also
: [The Customer  Profile]({{site.mc_baseurl}}/creating-a-customer/the_customer_profile_steps.html)
