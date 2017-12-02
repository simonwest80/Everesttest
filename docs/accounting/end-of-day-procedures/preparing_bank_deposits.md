---
title: Prepare Bank Deposits
---

# Prepare Bank Deposits


Collections from customers are accounted in the Receipts Journal. **Everest** is generally configured to transfer  all collections to a Payments Clearing account, which acts much like your  desk drawer or the cashier's drawer. The collections are verified at the  end of business day and journal entries are made in the general journal  to transfer the funds from the payment clearing account to your bank account.  This transfer acts as your bank deposit, and creates the proper transactions  to achieve a simple bank reconciliation procedure at month-end. It is  important to have the deposit transaction reduce the payment clearing  account balance to zero for the next day's operations.


{:.steps}
To make a bank deposit of all accounts at  the end of the day, do the following:

- Select **Accounting** > **Bank 
 Deposit**. You will see the **Bank 
 Deposit Wizard**. To make a bank deposit, you need to set the filter  for the undeposited receipts and collections.
- To filter your  undeposited receipts, in the **Payment 
 Method** field, click the ![]({{site.acc_baseurl}}/img/browse_button_acc.gif) button and select the payment  methods from the **Selection** dialog  box.



![]({{site.acc_baseurl}}/img/bank_deposit_wizard_selection_dialog_acc.gif)


**Figure: Selection Dialog Box**

- Click **OK**.
- Set the **Dates** filter as required. All undeposited  receipts generated for the period, for the selected payment methods display  below the Date filter in the Top grid.
- In the Top  grid, select the required receipts for making deposits by selecting the  check boxes on each row.



![]({{site.acc_baseurl}}/img/bank_deposit_wizard_filtered_acc.gif)


**Figure: Bank Deposit Wizard - Filtered**

- In the **Select Bank to Deposit** drop-down list,  select the bank account that will receive the deposit.



![]({{site.acc_baseurl}}/img/bank_deposit_wizard_select_bank_acc.gif)


**Figure: Bank Deposit Wizard - Select Bank to  Deposit Field**

- In the Bottom  grid, enter the adjustment amount for each payment method if there are  any adjustment amounts, such as bank fees or credit card charges. This  amount will be accounted in the Adjustment account defined in the preference  setting for each payment method (path: **File**  > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Miscellaneous** tab).



![]({{site.acc_baseurl}}/img/bank_deposit_wizard_bottom_grid_acc.gif)


**Figure: Bank Deposit Wizard – Bottom Grid (Adjustment)**


**![]({{site.acc_baseurl}}/img/bank_deposit_wizard_completed_acc.gif)**


**Figure: Bank Deposit Wizard - Completed**

- Click the **Save** button. The system creates a General  Journal for the bank deposit when you save the bank deposit and flags  the payments as Deposited in the payment register. An **Information**  dialog box displays with the deposit slip number.



**![]({{site.acc_baseurl}}/img/bank_deposit_wizard_info_dialog_acc.gif)**


**Figure: Information Dialog Box**

- Click **Yes** on the **Information**  dialog box to view the General journal.



![]({{site.acc_baseurl}}/img/bank_deposit_wizard_journal_acc.gif)


**Figure: Bank Deposit Journal Created**

- After you close  the General Journal, a **Print Deposit 
 Slip** dialog box displays the deposit slip ID.



**![]({{site.acc_baseurl}}/img/bank_deposit_wizard_deposit_slip_dialog_acc.gif)**


**Figure: Print Deposit Slip Dialog Box**

- Click **Print** or **Preview**  to print/preview the deposit slip.



You can use the Deposit Slip as an attachment to deposit  the end of day receipts at the Bank.


{:.note}
You can view the deposit slip at any time  from the **Bank Deposit Wizard**.  Press **Ctrl + R** or select **Options** > **Deposit 
 Slip Report**. Enter the deposit slip ID in the **Select 
 Deposit ID** field and click Preview or Print.


{:.warn}
Warning: If the deposit status is marked **'Deposited'** in the **Payments 
 Register** browser, the receipt will not be listed in the **Bank 
 Deposit Wizard** even if the receipt is still undeposited and vice  versa. Be extremely cautious while marking a payment as deposited in the  **Payments Register** browser; it  is a good practice to restrict security rights for changing the deposit  status in this browser only to authorized personnel.


{:.see_also}
See also
: [Bank Deposit  Wizard]({{site.acc_baseurl}}/end-of-day-procedures/bank-deposit-wizard/bank_deposit_wizard_acc.html)
: [End of Day Procedures]({{site.acc_baseurl}}/end-of-day-procedures/end_of_day_procedures.html)
