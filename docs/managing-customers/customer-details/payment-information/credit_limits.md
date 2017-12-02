---
title: Credit Limit
---

# Credit Limit


Credit limit information includes the following:

- Whether the  customer is put on credit hold and the reason for the same.
- The credit  limit for the customer in the customer's currency.
- When the customer  is to be put on automatic credit hold. A customer can be automatically  put on credit hold:


- If the balance is  overdue by the specified number of days.
- If the effective  balance or net balance exceeds the credit limit by the specified amount.  The settings you make in the **Customers**  dialog box (path: **File &gt; Setup &gt; 
 Preferences &gt; Flow Control &gt; Customers**) determines whether  the effective balance or the net balance is considered.
- If both the conditions  are met.



If either of the options **Number of 
 days past due** or **Amount Over Credit 
 Limit** is selected, the customer is put on auto credit hold if the  selected condition is met.


**On Credit Hold**


**![]({{site.mc_baseurl}}/img/manual_credit_hold_mc.gif)**


**Figure: Manual Credit Hold**
: Select this option to manually put the customer  on credit hold. Click the **Notes**  icon ![]({{site.mc_baseurl}}/img/managing_customers_notes_icon.gif) beside this field to specify reasons for putting  the customer on hold and to view the hold history. It shows if and when  a customer was manually put on hold, if and when the hold was removed,  and the person who performed the action. It also shows information on  automatic holds.


**On Credit Hold (Automatic)**


**![]({{site.mc_baseurl}}/img/automatic_credit_hold_mc.gif)**


**Figure: Automatic Credit Hold**
: If the customer is put on automatic credit hold,  this box shows the current status and **Everest**  adds comments, stating the reason for putting the customer on automatic  credit hold. You can view the comments by clicking the **Notes**  icon. Any existing notes are shown below the automatic credit hold note.
: ![]({{site.mc_baseurl}}/img/note.gif)  If  you clear the **On credit hold** check  box manually, **Everest** checks if  the **Number of days past due** and  the **Amount Over Credit Limit** check  boxes in the **Customer** profile  (path: **Invoicing &gt; Customers &gt; 
 Edit &gt; In New Window &gt; Payment Information** tab) are selected.  If either or both of the boxes are checked, and the selected condition  is met, the customer continues to be on credit hold. The automatic credit  hold conditions are checked whenever the **Customer**  profile or a sales document belonging to the customer is opened, or when  the customer is selected in a document.
: ![]({{site.mc_baseurl}}/img/example.gif)  A  customer’s credit limit is USD 5000, and the Amount Over Credit Limit  is USD 1000. The customer’s net balance is USD 5500, which considers a  deposit of USD 250 on a system sales order with “Prepay” terms. You create  another invoice (with ‘On Account’ terms) for USD 1000. The customer’s  net balance increases to USD 6500.
: In the Customers dialog box, you define  the formula for effective balance as:
: Total value of all sales invoices LESS  Total deposits on sales orders with ‘Prepay’ terms.
: Since the effective balance is USD 6250  (5500+1000-250), the customer is put on hold automatically. Everest adds  the following comments automatically:
: Account automatically put on hold because  customer is over the limit by USD 1250.00. Balance is USD 6500.00, effective  balance USD 6250.00 with credit line of USD 5000.00. (10/07/2008 07:28:23  PM).
: If the number of days past due date is  15 days, the customer is put on hold automatically, after the expiry  of 15 days. Everest adds the following comments automatically:
: Account automatically put on hold because  SI - 1025 is  45 days past due. The maximum number of days this account can be past  due is 15. (10/10/2008 10:59:45 PM).
: **Everest** logs  a new event **** when a customer is  put on automatic credit hold. You can view events **** from the **Events** log (path:  **Utility &gt; All Events**) or the  **Customers** browser (path: **Invoicing &gt; Customers &gt; Options &gt; 
 Events History**).
: ![]({{site.mc_baseurl}}/img/note.gif)  Net  Balance = Total value of posted/unposted  sales invoices and credit memos + Deposits on credit orders - Deposits  on sales orders
: The value of sales orders are also considered  while checking if the customer is over the specified credit limit. If  you create an “On Account” sales order, **Everest**  warns you if the customer is already over the credit limit or is on hold.
: If a customer is automatically put on credit  hold, **Everest** allows you to create  orders, invoices, and memos (with  “Prepay”  and “COD” terms) without prompting you that the credit limit has been  exceeded.


**Credit Limit**
: The credit limit has to be specified in the customer's  currency. When a sales document with "On Account" terms is created  for the customer, **Everest** warns  you if the credit limit exceeds or the customer is on hold. You can create  the document, only if you have the required security rights.
: You can set the default credit limit for new customers  in the **Credit Limit** field of the  **Customers** tab (path: **File**  > **Setup** > **Accounting**  > **Location/Sub-Location**). This  credit limit amount is displayed in this field, by default. You can modify  the credit limit for specific customers anytime from the **Customer**  profile.
: ![]({{site.mc_baseurl}}/img/note.gif)  This  field cannot have a negative value and the last decimal is rounded off.  The number of decimals displayed in this field depends on the number of  decimals specified in your settings:


 - **Currency**  profile (path: **File** > **Setup** > **Accounting**  > **Multi-Currency** > **Currency** > **Options**  > **Edit** > **In 
 New Window** > **Decimals to display**  field)


 - **Regional 
 Settings Properties** dialog box - From the Currency tab in the regional  settings. You can modify the regional settings from the Control Panel  of your operating system.




Automated Hold Conditions


The automated hold conditions in this section can be set  to automatically place the customer on hold if the conditions are met.  Likewise, if the customer no longer meets the conditions specified, the  system can automatically remove the automatic credit hold if you select  the **Remove automated customer on hold 
 automatically** option in the **Other 
 Flow Control** dialog box (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Other 
 Flow Control** > **General**  tab).
: ![]({{site.mc_baseurl}}/img/lens.gif)[Other  Flow Control - General Tab]({{site.bp_chm}}/other-flow-control/the-other-flow-control-dialog-box/other_flow_control_general_tab_step_by_step.html)


**Number of days past due**
: The due date for payment is computed based on the  payment terms. Check this box to put the customer on automatic hold if  payment is not received even after the expiry of the additional number  of days (also called days past due) specified here.
: Specify the number of days from the payment date  in the box below this field.


![]({{site.mc_baseurl}}/img/example.gif)   If the **Number of days past due**  is 15 days, the customer is put on hold automatically after 15 days. If  the customer makes the required payments according to the payment terms  after the automatic credit hold is placed and the **Remove 
 automated customer on hold automatically** option in the **Other****Flow Control** dialog box is selected  (path: **File** > **Setup**  > **Preferences** > **Flow 
 Control** > **Other Flow Control**  > **General** tab), the system  automatically removes the credit hold since the account is current.


**Amount over credit limit**
: Select this check box to put the customer on automatic  hold if the amount due from the customer exceeds the credit limit plus  the amount over credit limit. Enter the amount over the credit limit applicable  to the customer in the box below this field.
: The amount due from the customer includes both posted  and unposted amounts.


![]({{site.mc_baseurl}}/img/example.gif)  If  the customer’s credit limit is $5,000 and the amount over credit limit  is $3,000, the customer is put on hold automatically if the current balance  exceeds $8,000. If the customer pays the balance down to below $6,000  after the automatic credit hold is placed and the **Remove 
 automated customer on hold automatically** option in the **Other 
 Flow Control** dialog box is selected (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Other 
 Flow Control** > **General**  tab), the system automatically removes the credit hold since the balance  is less than $8,000 after the payment.


{:.see_also}
See also
: [Customer defaults]({{site.mc_baseurl}}/customer-preferences/customer_defaults.html)
: [Events History]({{site.mc_baseurl}}/customer-profile-options/other-options/events_history_customers.html)
