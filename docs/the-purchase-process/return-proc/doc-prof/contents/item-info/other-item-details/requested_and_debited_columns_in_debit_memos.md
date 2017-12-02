---
title: Requested and Debited Columns in Debit Memos
---

# Requested and Debited Columns in Debit Memos


**Requested**
: The **Requested**  displays:

- Zero when a  debit memo is created directly.
- The quantity  that was on order and not returned at the time of creating the debit memo.



{:.example}
If 300 units of an item were on order, and  the quantities are returned in 2 lots of 100 and 200, the first debit  memo would display 300 as the quantity requested while the second one  would display 200.


**Debited**
: This column displays the quantity of the item returned.  When a debit order is converted to a debit memo, the **Debited**  column displays the quantity committed (if quantity was committed on the  item). If quantity has not been committed on the item, it displays the  quantity requested, unless you have selected the option **Set****the** **quantity****received** **value****to** **zero****when** **converting****a** **purchase****order/debit order** **to****a** **purchase****receipt/debit memo** (path: **File** > **Setup**  > **Preferences** > **Flow****Control** > **Documents**  > **Miscellaneous** > **Others** > **Others 
 1** tab).


{:.note}
This option works only for auto-serialized and inventoried (non-serialized)  items.


For serialized items,  the  shipped column always displays 'zero'.
: You can enter a quantity that is greater than the  requested quantity.


**Positive and Negative Quantities on a Debit Memo**
: You can have both positive and negative quantities  of items on a document. Positive quantities on a debit memo indicate that  the item has been returned to the vendor. Negative quantities indicate  that the item has been received.
: A serial number generated on a debit memo will be  in an “out” type of area.


{:.see_also}
See also
: [Other Information]({{site.pp_baseurl}}/misc/other_information_sr_con.html)
