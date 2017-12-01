---
title: Impact of Quantity Adjustment on Inventoried Items
---

# Impact of Quantity Adjustment on Inventoried Items


In the absence of any distinguishing features as numbers, transfer of  inventoried items poses a major hurdle. It is virtually impossible to  identify the source of items that show up as excess in a bin. Also, it  is very difficult to ascertain the new location of items that are short  in a bin. This problem can be overcome by doing a quantity adjustment,  which automatically adjusts the system stock to the physical stock. The  impact of this adjustment can be summarized as below:

- Items are added  or written off at the average cost.
- Quantity adjustment  for the variance quantity for an item in one Stock Count document offsets  the variance quantity for the same item in other Stock Count documents.
- The net variance  for an item in all the count sheets amounts to the quantity that is actually  added or written off.



{:.example}
Item 101 FG Tips is stocked in six bins. Counting  in bins 1, 2, and 3 is completed first; thereafter, the item is counted  in bins 4, 5, and 6. The system count puts the stock of 101 FG Tips at  60; however, the physical count places it at 59.


| Bin | System Qty | Physical Qty | Variance Qty | Qty Adj | Updated System Qty |
| 1 | 10 | 20 | 10 | 10 | 20 |
| 2 | 10 | 4 | -6 | -6 | 4 |
| 3 | 10 | 3 | -7 | -7 | 3 |
| Total | 30 | 27 | -3 | -3 | 27 |



| Bin | System Qty | Physical Qty | Variance Qty | Qty Adj | Updated System Qty |
| 4 | 10 | 11 | 1 | 1 | 11 |
| 5 | 10 | 11 | 1 | 1 | 11 |
| 6 | 10 | 10 | 0 | 0 | 10 |
| Total | 30 | 32 | 2 | 2 | 32 |



A quantity adjustment is done to reconcile the system stock to the physical  stock. The net variance of 1 item in both the count sheets is zeroed out  by writing off one quantity.


{:.see_also}
See also
: [Impact  of Quantity Adjustment]({{site.wm_baseurl}}/inv-adj/stock-count/impact-of-quantity-adjustment/impact_of_quantity_adjustment.html)
