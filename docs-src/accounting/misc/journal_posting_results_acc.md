---
title: Journal Posting Results
---

# Journal Posting Results


**Journal #**
: This unique number identifies the journal you chose  to post.


**Posted**
: A checked box indicates the journal posted properly;  otherwise it remains unchecked.


**Remarks**
: This column display the status of the journal:

- : **Posting 
 complete** - the journal posted successfully.
- : **Amounts 
 do not balance for transaction #&lt;number&gt;** - the journal did  not post because the debit and credit amounts do not balance on the transaction  indicated.
- : **Journal 
 not printed** - the journal did not post because it has not yet been  printed.

: You can select the preference **Allow 
 user to post a journal even if it is not printed** to allow Everest  to post an unprinted journal. Make this change in the Other Flow Control  preferences (path: **File** > **Setup** > **Preferences**  > **Flow Control** > **Other 
 Flow Control** > **General**  tab).

- : **Journal 
 is locked by user &lt;xxx&gt; at Workstation &lt;machine name&gt;**  - the journal did not post because the user indicated has this journal  open on the computer indicated.
- : **Document 
 is locked by user &lt;xxx&gt; at Workstation &lt;machine name&gt;**  - the journal did not post because the user indicated has a document contained  in this journal open on the computer indicated.
- : **Journal 
 falls in a closed/invalid period** - the journal did not post because  the fiscal period in which it must be posted is either closed or invalid/not  defined in Everest.
- : **Account 
 used in transaction is not defined - transaction #&lt;number&gt;**  - the journal did not post because the account number in the transaction  indicated is missing or invalid.
- : **Check 
 not printed for transaction #&lt;number&gt;** - the journal did not  post because a check has not yet been printed for the transaction indicated.



Note that in the case of multiple posting errors for a single journal,  the system will only display the first error encountered. If you fix that  problem and try to repost, the next error will display.


{:.see_also}
See also
: [Posting]({{site.acc_baseurl}}/accounting-structure-in-everest/posting/posting.html)
: [Posting  Journals to the Accounts]({{site.acc_baseurl}}/purchasing/purchase-jrnl-proc/common-jrnl-proc/posting/posting_journals_to_the_accounts.html)
