---
title: Process a Debit Memo
---

# Process to a Debit Memo


Items received against a debit order are processed through the **Memo** option (path: **Debit****Order** profile > **Options**  > **Process** > **Memo**).  When this option is selected, the details of the debit order are copied  to a **Debit** **Memo**  profile.


When you save the debit memo, the **Debited**  column of the converted debit order is updated with the quantity returned  (as entered in the **Debited** column  of the debit memo). If quantities committed on the debit order are returned  on the debit memo, the quantity in the **Committed**  column of the debit order reduces. You can view fully shipped debit orders  in the **Shipped Debit Orders** browser  (path: **Purchasing &gt; Debit Orders &gt; 
 Options &gt; Shipped Debit Orders**).


![]({{site.pp_baseurl}}/img/lens.gif) [Requested,  Committed and Debit Columns in Debit Orders]({{site.pp_baseurl}}/return-proc/doc-prof/contents/item-info/other-item-details/requested_committed_and_debited_columns_in_debit_orders.html)


If items are returned in stages, you can create a debit memo for each  return against the debit order.


{:.see_also}
See also
: [Debit Memos]({{site.pp_baseurl}}/return-proc/dms/debit_memos.html)
: [Partial Returns]({{site.pp_baseurl}}/return-proc/dos/do-processes/partial-returns/partial_returns_proc_dm.html)
