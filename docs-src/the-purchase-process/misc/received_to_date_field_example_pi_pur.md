---
title: Received to Date Field Example
---

# Received to Date Field Example


{:.example}
The steps in the following table illustrate  how the **Received to Date** field  changes for a line item when you create a purchase receipt and purchase  invoices from the same purchase order. In this example, the preference  option **Set the quantity received value 
 to zero when converting a purchase order to a purchase invoice**  (path: **File** > **Setup**  > **Preferences** > **Flow 
 Control** > **Documents**  > **Miscellaneous** tab > **Others** tab > **Others 
 1** tab) is NOT selected.


| Step # | Step | Ordered Quantity | Received Quantity | Invoiced Quantity | Received to Date |
| 1 | (PO) - Create a PO with an ordered quantity of 100. | 100 | 0 | 0 | N/A |
| 2 | (PO > PI) - Convert the PO to a PI. Notice the quantities  displayed but do not save the PI yet. The **Received <br/> to Date** field initially displays the **Ordered**  quantity from the PO. | 100 | 100\* | 100 | 100\* |
| 3 | (PO > PI Continued) - On the PI, change the **Received** quantity to zero (0). Notice  that the **Received to Date** field  changes from 100 to zero (0). | N/A | **0** | 100 | 0 |
| 4 | (PO > PI Continued) - Change the **Invoiced**  quantity to 40 and save the PI. Notice that the **Received <br/> to Date** field does not change. | N/A | 0 | 40 | 0 |
| 5 | (PO > PR) – Convert the original (and now backordered)  PO to a purchase receipt. | 100 | 100 | 40 | N/A |
| 6 | (PO > PR Continued) – Change the **Received**  quantity to 15 and save the PR. | 100 | **15** | 40 | N/A |
| 7 | (PO > PI) – Convert the original PO to another PI.  Notice the quantities displayed but do not save the PI yet. | 100 | 85\*\* | 60 | 100\*\* |
| 8 | (PO > PI Continued) – Change the **Received**  quantity to 20 and save the PI. Notice that the **Received <br/> to Date** field displays the sum of the quantities received in the  PR and in the PIs. | 100 | 20 | 20 | 35 |

: \*If the **Set the 
 quantity received value to zero when converting a purchase order to a 
 purchase invoice** option had been selected, the **Received**  and **Received to Date** fields would  have displayed a zero (0).
: \*\*If the **Set the 
 quantity received value to zero when converting a purchase order to a 
 purchase invoice** option had been selected, the **Received**  field would have displayed a zero (0) and the **Received 
 to Date** field would have displayed 15.


The **Received to Date** field of  the latest purchase invoice created displays the sum of the Received quantities  entered when creating the purchase receipt and both purchase invoices  from the original purchase order:


| Quantity received on 1st PI created: | 0 |
| Quantity received on PR created: | 15 |
| Quantity received on 2nd PI created: | 20 |
| Total Received to Date | 35 |



The purchase documents display the quantities shown in the following  table.


| Document Created from PO | Quantity Received | Received to Date |
| 1st PI Created | 0 | 0 |
| PR Created | 15 | N/A |
| 2nd PI Created | 20 | 35 |



Since the **Received to Date** field  is based on the quantity received at the time of creating the invoice,  the **Received to Date** field of  the previous purchase invoice document created (1st PI created) does not  update based on additional quantities received. Likewise, the **Received 
 to Date** field for the second PI created will not update when receiving  additional quantities.


{:.see_also}
See also
: [Received  to Date Column]({{site.pp_baseurl}}/misc/received_on_invoice_column_pi_pur.html)
