---
title: How do I Merge Accounts?
---

# How do I Merge Accounts?


You can merge a Detail account into another account from  the **Chart of Accounts** browser.  The Parent Account, Control Account, and Currency of the detail account  must be the same to merge accounts.


{:.example}
Your Company has grown and you have a huge  number of accounts in the Tree-view of the COA. You identify the master  account and merge all the redundant Detail accounts to the master account,  and then purge the redundant accounts. Your COA browser is well structured  after merging accounts.


{:.steps}
To merge an account, do the following:

- Select the detail  account to be merged from the Chart of Accounts browser (path: **Accounting**  > **Chart of Accounts**).
- Select **Options**  > **Merge / Rename**.  You  will see the **Merge and Rename COA Accounts**  dialog box. The account you selected for merging is displayed in the **Existing Account Code** column.



![]({{site.sc_baseurl}}/img/merge_and_rename_accounts_sc.gif)


**Figure: Merge and Rename COA Accounts Dialog  Box**

- Select **Merge**  from the **Action** drop-down list.
- In the **Destination 
 Account Code** column, select the destination account for the merge  process. The account to be merged, specified in the Existing Account Code  box, will merge into the account specified in the Destination Account  Code.
- Click **Start**  to begin the account code merge process.

A log file displays with the status of the merge action.



{:.note}
Select each account in a separate row to merge  multiple accounts at a time.


{:.note}
After using the "Merge Accounts"  feature, it is possible that data from closed years will be affected.  For example, the Trial Balance report that previously showed two accounts  will display the same balance under one account after running the utility.


{:.see_also}
See also
: [Merge  and Rename COA Accounts]({{site.sc_baseurl}}/misc/merge_and_rename_coa_accounts_coa_browser_option_sc.html)
: [How  do I Rename an Account Code?]({{site.sc_baseurl}}/misc/how_do_i_rename_an_account_code_sc.html)
