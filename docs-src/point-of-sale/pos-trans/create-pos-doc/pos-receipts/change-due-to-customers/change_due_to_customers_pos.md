---
title: Change Due to Customers
---

# Change Due to Customers


There may be instances when a customer pays more than the amount that  appears on the Point of Sale (sales invoice) document. The cashier at  the Point of Sale terminal has to refund the change due to the customer.


For refunding change due to customers, set a preference by checking  the **Default Payment Method for Change 
 Due** field in the following dialog boxes:

- **Cash 
 Register** profile (path: **File**  > **Setup** > **Miscellaneous**  > **Cash Register** > **Options** > **Edit**  > **In New Window**)
- **WorkStation Settings**  dialog box (path: **File &gt; Setup &gt; 
 Preferences &gt; WorkStation 
 Settings** **&gt; General &gt; Others**  tab)
- **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab).



![]({{site.pos_baseurl}}/img/lens.gif) [Default  Preferences - Change Due to Customers]({{site.pos_baseurl}}/misc/default_preferences_change_due_to_customers_defaults.html)


{:.note}
**Everest** uses the following precedence  for the default payment method for change due:


1. Cash register


2. Workstation settings


3. The preference setting in accounting defaults


The change due to a customer is displayed in the **Change**  field of the Point of Sale (sales invoice) document.


{:.note}
**Everest** allows  for only cash type of over payments. You have to select **Cash**  in the **Pay By** column of the **Payment Details** dialog box.


You cannot save the document until the balance is reduced to zero. Insert  a new line to enter the change due amount in the Payment Details Grid.  The payment method and the currency for this line default to those in  the previous line.


When you click **OK** on the **Payment Details** dialog box, an **Information** dialog box appears that  displays the change due amount in the base currency as well as the currency  selected for the change due. This acts as a reminder to the cashier to  pay the amount due to the customer.


{:.see_also}
See also
: [Accounting  Entries - Change Due to Customers]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-receipts/change-due-to-customers/accounting-entries/accounting_entries_change.html)
