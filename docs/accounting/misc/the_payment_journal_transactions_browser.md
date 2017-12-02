---
title: The Payment Journal Transactions Browser
---

# The Payment Journal Transactions Browser


This browser is displayed when **Options 
 &gt; List Transaction** is selected from the **Unposted 
 Payment Journals** browser. The **Payment 
 Journal Transactions** browser lists all the transactions in the  journal with details such as the vendor code, bank code and amounts debited  or credited, whether the payment is made by a manual/computer check and  whether the check has been printed.


If payment is made through a credit card, the card number is displayed  in the **Reference** column. Credit  card numbers are masked using the format XXXXXXXXXXXX<last  four digits of the card> when the **Enable 
 Extended Mode** check box is cleared (path: **File 
 &gt; Setup &gt; Preferences &gt; Workstation Settings &gt; Company Settings**  tab).


The transaction status for the records in this browser is mentioned  below:

- **Normal**  - The default transaction status for all transactions is **Normal**.  Also, the transactions that have been re-created after voiding or reversing  is assigned **Normal** status.
- **Void**  – The transaction that has been voided is assigned **Void**  status.
- **Reversed**  – The original transaction that has been reversed using **Reverse**  option is assigned **Reversed** status.
- **Reversal**  – The new transaction that is the opposite of the original transaction  is assigned **Reversal** status.



The **Payment Journal Transactions** browser  has the following additional options:

- **Select/Unselect 
 All -** Use this option to select or de-select all the records in  the browser. This is a toggle option.
- **Print 
 Check** - You can print the check for each transaction separately  from this browser. Use this option if you want to print only one check  at a time. You can also print multiple checks by highlighting the required  transactions and selecting the **Print 
 Check** option.



**![]({{site.acc_baseurl}}/img/lens.gif) [Printing  Checks from the Payment Journal Transactions browser]({{site.acc_baseurl}}/vendor-payments-and-refunds/payment-jrnl-proc/printing-checks/printing_checks_payment_journals_transactions_browser.html)**

- **Split 
 Journal** - If a journal that is not posted contains too many transactions,  you may split the journal. Splitting the journal moves the selected transaction(s)  into a new journal.

: ![]({{site.acc_baseurl}}/img/lens.gif) [Split  Payment Journals]({{site.acc_baseurl}}/misc/split_journal_payment_journal.html)

- **Purge 
 transaction** - This option allows you to delete a transaction from  the **Payment Journal Transactions**  browser.



**![]({{site.acc_baseurl}}/img/lens.gif)[Purging  Transactions - Payment Journals Browser]({{site.acc_baseurl}}/vendor-payments-and-refunds/payment-jrnl-proc/purge-payment-jrnls-trans/purging-trans/del_trans_from_pmnt_jrnls_browser.html)**

- **List 
 entry** - The list entry option allows you to view the entire accounting  entry for a selected transaction.



The options common to all browsers in **Everest**  are also available in this browser.


![]({{site.acc_baseurl}}/img/lens.gif) [Standard  Browser Options]({{site.wwe_chm}}/everest-client/ui/browsers/standard_browser_options.html)


{:.see_also}
See also
: [List  Transaction - Unposted Payment Journals Browser Option]({{site.acc_baseurl}}/misc/general_ledger_detail_payment_journal_browser.html)
