---
title: Processing a Credit Memo
---

# Processing a Credit Memo


**A credit order can be processed to a credit  memo by using the **Process &gt; Memo**  option. When you select this option, the details of the order are copied  to a **Credit Memo** profile. When  the credit memo is saved, the **Credited** column of the credit order is updated with the quantity returned.  When you convert the credit order to a credit memo, the quantity in the  'committed' column appears in the 'credited' column by default.**


**Every time a shipment is received against  a credit order, a credit memo can be created.**


**Partial Returns of Inventoried Items**


**If items against a credit order are returned  in various stages, multiple credit memos can be created for the same credit  order.**


![]({{site.sp_baseurl}}/img/example.gif) If five computers are expected  to be returned, but only three are returned, a credit memo can be created  for the three items returned initially. Later when the rest of the computers  are returned, another credit memo can be created.


**When partial returns are made against a  credit order, the credit order gets converted to a backorder. The status  of the credit order changes to **Backorder** on the document and in the **Credit 
 Orders** browser. This status remains until the remaining items are  received. When all the items are received, the credit order status becomes  **Closed**.**


{:.see_also}
See also
: [Requested,  Committed and Credited Columns]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/item-info/details/requested_committed_and_credited_columns_in_credit_memos.html)
: [Creation  of Credit Memos]({{site.sp_baseurl}}/sales-ret-docs/cms/create-cm/create-new-cm/creating_a_new_credit_memo.html)
: [Back  End Processes for the Credit Order]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/convert-to-a-credit-memo/backend_processes_for_the_credit_order.html)
