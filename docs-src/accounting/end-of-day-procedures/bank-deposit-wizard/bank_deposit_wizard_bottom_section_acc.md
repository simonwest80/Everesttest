---
title: Bank Deposit Wizard - Bottom Section
---

# Bank Deposit Wizard - Bottom Section


The Bottom Grid


The Bottom grid lists the consolidated amount for each payment  method. It gives details of the count of receipts for each payment method,  any adjustment amounts with accounts, and the total amount for each payment  method.


The ![]({{site.acc_baseurl}}/img/bank_deposit_wizard_hide_adj_acc.gif) button functions as a toggle key to display/hide  the adjustments in the Bottom grid.


**Select Bank Account to Deposit**
: Select the bank account to be used to make your  deposit from the drop-down list which displays all active bank accounts  in Everest. The amounts of the receipts selected in the Top grid will  be deposited in the account selected in this field.


Adjustments


Use the adjustments section in the Bottom grid to make any  adjustments to the receipts being deposited, such as transaction fees.


**Payment Type / Method**
: Displays the payment method selected by you in the  filter.


**Count**
: Displays the count of undeposited receipts for each  payment method.


**Adjustment Account**
: Displays the adjustment account selected for each  payment method. This account is selected in the preference setting (path:  **File** > **Setup**  > **Preferences** > **Defaults**  > **Accounting** > **Miscellaneous**  tab).
: ![]({{site.acc_baseurl}}/img/lens.gif) [Accounting  Dialog Box – Miscellaneous]({{site.acc_baseurl}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_miscellaneous.html)


**Adjustment Amount**
: The fields in this column are only editable if an  adjustment account has been defined for the payment method. Enter any  adjustment amount for each payment type. This field accepts only base  currency and can be positive or negative.


{:.example}
A merchant needs to pay 15 cents for each  transaction using a VISA card. The merchant calculates the VISA receipts  on a particular day to be 10 transactions amounting to $1000. The transaction  fee that will be deducted from the bank account is $1.50. The merchant  selects an expense account (VISA transaction fee account) and enters this  amount as ($1.50).


**Amount**
: The Amount column displays the exact amount of the  undeposited receipts for that payment method.


**Total Amount**
: This column is calculated based on the Adjustment  Amount and Amount columns and displays the total of the amount and adjustment  amount for the payment method.


{:.see_also}
See also
: [Bank  Deposit – Options Menu]({{site.acc_baseurl}}/end-of-day-procedures/bank-deposit-wizard/bank_deposit_options_menu_acc.html)
: [Bank Deposit  Wizard]({{site.acc_baseurl}}/end-of-day-procedures/bank-deposit-wizard/bank_deposit_wizard_acc.html)
