---
title: Fixed Asset Journal Dialog Box
---

# Fixed Asset Journal Dialog Box


The **Fixed Asset Journal** dialog  box enables you to specify the assets that have to be depreciated and  the number of depreciation entries to be created.


**Transaction Date**
: Enter the date of this transaction. The current  system date is displayed by default, if the login period is the active  period or if no active period has been defined. If the login date does  not belong to the active period, the first date of the active period is  displayed in this field.


**Starting and Ending Code**
: Specify the range of asset codes to be depreciated.  You also have the choice of selecting only one asset for depreciation,  by specifying the same asset code in the starting and ending code fields.


**Narration**
: Enter a brief description that will detail the transactions  when the journal is created. This description is printed on applicable  reports. You can view the description entered here in the general journal  that is created to account for this transaction.
: ![]({{site.acc_baseurl}}/img/lens.gif)<font style="color: #ff0000;" color="#FF0000"> </font>[Notes  Column - General Journal Profile]({{site.acc_baseurl}}/misc/transaction_entries_manual_gj.html#notes_column_general_journal_profile)


**Generate Entries**
: Select the appropriate option.
: **Till Date** -  Select this option to generate the depreciation entries upto  the transaction date. A consolidated depreciation entry for all the months  from the last generation date to the current date is created.


![]({{site.acc_baseurl}}/img/example.gif)  If  monthly depreciation of an asset is $10000 and the last generation was  done on December 31, 2000. If the date of next generation is May 31, 2001,  selecting 'One entry' will create a depreciation entry for $10000. If  the option 'Till date' is selected, then a single depreciation entry would  be created for $50,000 from January to May.
: **One** - When  this option is selected, a single depreciation entry is generated. The  transaction amount is the sum total of the amount displayed in the **Depreciation (per month)** field of each  selected asset's profile.


![]({{site.acc_baseurl}}/img/note.gif)  Depreciation  is not prorated based on the transaction date. If a depreciation entry  is created in the middle of a month, then the depreciation is calculated  for the entire month.


{:.see_also}
See also
: [Creating  a Depreciation Entry]({{site.acc_baseurl}}/fixed-assets/depreciating-an-asset/creating_a_depreciation_entry.html)
