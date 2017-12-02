---
title: The Cash Register Profile - Payment Type - Miscellaneous Tab
---

# The Cash Register Profile - Payment Type - Miscellaneous Tab


**Allow split payments in multiple currencies**
: Select this check box to receive payments and change  due from customers in multiple currencies. The following columns are added  to the **Payment Details** dialog  box.


| Column name | Displays the |
| Pay Rate | Exchange rate of the payment currency with respect to  the base currency |
| Currency | Payment currency |

: The **Amount**  column in the **Payment Details**  dialog box displays the amount to be paid in the payment currency. If  you do not select this option, the amount is displayed in the document  currency.


**View balance and change due in any currency**
: Select this check box to view the balance amount  and change due in multiple currencies. After a part of the amount is paid  in a particular currency, the balance amount can be viewed in another  currency. Further, after making payment in a particular currency, you  can view the amount of change due in another currency. The **Balance 
 In** or **Change In** fields  are displayed if the above option is selected.
: If the payment amount is less than or equal to the  document total, you will see the **Balance 
 in** field and if the payment amount is more than the document total,  you will see the **Change in** field.  By default, the **Balance in** field  displays the amount in document currency.
: **Everest**  displays the change due through an information window both in the base  currency as well as in the currency selected for change due.
: This field is enabled only when you select the **Allow split payments in multiple currencies**  option.


{:.note}
If different payment currencies are used, different transaction will  be created. But if different payment methods are used, then different  journals will be created for each payment method, if the associated bank  account is different for each method.


**Allow change due against non-cash payments**
: Select this check box to return change due in cash  to a customer against excess amount received in any other mode of payment  such as check, credit card, etc. However, you require adequate security  rights to do so.


**Default payment  method for change due**
: Specify the default payment method to be used for  change due to customers. The payment method defined for change due will  be used as the default payment method for change due when payments are  received through the relevant cash register.
: When you receive an excess amount of money from  a customer on account of a Point-of-Sale transaction, you will have to  refund the change due to the customer. This option allows you to specify  the default payment method to be used for change due to the customer.  Only cash type of payment methods are available for selection.
: You can also specify the default payment method  to be used for change due to customers in the Accounting dialog box (path:  **File** > **Setup**  > **Preferences** > **Defaults**  > **Accounting** > **Miscellaneous**  tab) and in the **Others** tabs of  the **Workstation Settings** profile  (path: **File** > **Setup**  > **Preferences** > **Workstation****Settings** > **General**  tab).


{:.note}
The precedence for using the default payment method  for change due by **Everest** is:


1. Cash register


2. Workstation settings


3. The preference setting in accounting defaults


{:.see_also}
See also
: [Payment  Type - Journal Group Information]({{site.pos_baseurl}}/misc/journal_group_information_cash_reg.html)
: [The  Cash Register Profile]({{site.pos_baseurl}}/pos-setup/cash-registers/setup/profile/the_cash_register_profilepos_set_up.html)
: [Setting  up a Cash Register]({{site.pos_baseurl}}/pos-setup/cash-registers/setup/setting_up_a_cash_register_pos_set_up.html)
