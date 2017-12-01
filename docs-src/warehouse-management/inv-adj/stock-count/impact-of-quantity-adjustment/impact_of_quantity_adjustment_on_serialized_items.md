---
title: Impact of Quantity Adjustment on Serialized Items
---

# Impact of Quantity Adjustment on Serialized Items


Determination of a mismatch between the system and physical stocks of  serialized items is easy. The following are indicative of a discrepancy:

- Serial numbers  available in the system are not available physically.
- Serial numbers  are available physically as well as in the system but not in the same  bin.



This aberration can be corrected by using the **Finalize 
 and Adjust Quantity** option. The corresponding items are displayed  in the **Serial Number Discrepancy Details**  browser. Select the items that you want adjusted and click **OK**  in this browser. The adjustments done are based on the kind of discrepancy.


| Discrepancy | Adjustments | Other Impacts |
| Serial number available physically but not available in the system in  the counted bin | Transfer of serial number from the bin in which system stock is available  to the bin in which the stock is physically available | - The stock transfer  quantity column shows the total number of serial numbers transferred.<br/>- Serial numbers  are transferred at the actual cost.<br/>- Stock transfer  value is the sum of the serial numbers transferred. |
| Serial numbers available in the system but not physically available | Serial numbers written off to an OUT area | - Adjustment  quantity shows the total number of serial numbers written off.<br/>- Serial numbers  are written off at the actual cost. The adjustment cost column shows the  weighted average of the actual cost of the serial numbers written off.<br/>- Adjustment  value is Adjustment Quantity multiplied by the Adjustment Cost. |



{:.example}
**Item 17 700 Monitor is stocked in three bins.  Create a Stock Count document for bins 1, 2, and 3 and complete the process  of counting in the same order. The impact of transfer of serial numbers  to the correct bins at the end of each stock count process is detailed  below.**


Counting in Bin


| Bin 1 | Bin 2 | Bin 3 | Out Area |
| System Sl. No. | Physical Sl. No. | System Sl. No. | Physical Sl. No. | System Sl. No. | Physical Sl. No. | Physical Sl. No. |
| 1 | 1 | 4 |  | 7 |  |  |
| 2 | 5 | 5 |  | 8 |  |  |
| 3 | 9 | 6 |  | 9 |  |  |



Reconciliation of serial numbers in Bin 1


| Bin 1 | Bin 2 | Bin 3 | Out Area |
| System Sl. No. | Physical Sl. No. | System Sl. No. | Physical Sl. No. | System Sl. No. | Physical Sl. No. | Physical Sl. No. |
| 1 | 1 | 4 |  | 7 |  | 2 |
| 5 | 5 | 6 |  | 8 |  | 3 |
| 9 | 9 |  |  |  |  |  |


- Serial numbers  2 and 3 are written off.
- Serial number  5 is moved from bin 2 to bin 1.
- Serial number  9 is moved from bin 3 to bin 1.
- Variance quantity  is zero.
- Adjustment  quantity is 2.
- Stock transfer  quantity is 2.



| Item Code | Serial # | Bin from | Bin to | Qty |
| 17 700 Monitor | 2 | Bin 1 | Out | -1 |
| 17 700 Monitor | 3 | Bin 1 | Out | -1 |
| 17 700 Monitor | 5 | Bin 2 | Bin 1 | 1 |
| 17 700 Monitor | 9 | Bin 3 | Bin 1 | 1 |



Counting in Bin 2


| Bin 1 | Bin 2 | Bin 3 | Out Area |
| System Sl. No. | Physical Sl. No. | System Sl. No. | Physical Sl. No. | System Sl. No. | Physical Sl. No. | Physical Sl. No. |
| 1 |  | 4 | 4 | 7 |  | 2 |
| 5 |  | 6 | 2 | 8 |  | 3 |
| 9 |  |  |  |  |  |  |



Reconciliation of serial numbers in Bin 2


| Bin 1 | Bin 2 | Bin 3 | Out Area |
| System Sl. No. | Physical Sl. No. | System Sl. No. | Physical Sl. No. | System Sl. No. | Physical Sl. No. | Physical Sl. No. |
| 1 | 1 | 4 | 4 | 7 |  | 6 |
| 5 | 5 | 2 | 2 | 8 |  |  |
| 9 | 9 |  |  |  |  |  |


- Serial number  2 is brought into bin 2 from the OUT area by way of a credit memo.
- Serial number  6 is written off and assigned to the OUT area.
- Variance is  zero.



Serial number discrepancy details


| Item Code | Serial # | Bin from | Bin to | Qty |
| 17 700 Monitor | 6 | Bin 2 | Out | -1 |



Counting in Bin 3


| Bin 1 | Bin 2 | Bin 3 | Out Area |
| System Sl. No. | Physical Sl. No. | System Sl. No. | Physical Sl. No. | System Sl. No. | Physical Sl. No. | Physical Sl. No. |
| 1 |  | 4 | 4 | 7 | 3 |  |
| 5 |  | 6 | 2 | 8 | 6 |  |
| 9 |  |  |  | 3 | 7 |  |
|  |  |  |  | 6 | 8 |  |



Reconciliation of serial numbers in Bin 3


| Bin 1 | Bin 2 | Bin 3 | Out Area |
| System Sl. No. | Physical Sl. No. | System Sl. No. | Physical Sl. No. | System Sl. No. | Physical Sl. No. | Physical Sl. No. |
| 1 |  | 4 | 4 | 3 | 3 |  |
| 5 |  | 2 | 2 | 6 | 6 |  |
| 9 |  |  |  | 7 | 7 |  |
|  |  |  |  | 8 | 8 |  |



Variance in bin 3 is zero.


{:.example}
**Item 17 700 Monitor is stocked in two bins.  Bin 1 is counted first and thereafter bin 2 is counted. The details of  the impact of the transfer of the serial numbers to the correct bins are  given below.**


Counting in Bin 1


| Bin 1 | Bin 2 | Out Area |
| System Sl. No. | Physical Sl. No. | System Sl. No. | Physical Sl. No. | Physical Sl. No. |
| 1 | 4 | 4 |  |  |
| 2 | 5 | 5 |  |  |
| 3 | 6 | 6 |  |  |



Reconciliation of serial numbers in bin 1


| Bin 1 | Bin 2 | Out Area |
| System Sl. No. | Physical Sl. No. | System Sl. No. | Physical Sl. No. | Physical Sl. No. |
| 4 | 4 |  |  | 1 |
| 5 | 5 |  |  | 2 |
| 6 | 6 |  |  | 3 |


- Serial numbers  1, 2, and 3 are written off and assigned to the OUT area.
- Serial numbers  4, 5, and 6 are moved from bin 2 to bin 1.
- Variance for  bin 1 is zero.



Counting in Bin 2


| Bin 1 | Bin 2 | Out Area |
| System Sl. No. | Physical Sl. No. | System Sl. No. | Physical Sl. No. | Physical Sl. No. |
| 4 | 4 | 1 | 1 |  |
| 5 | 5 | 2 | 2 |  |
| 6 | 6 | 3 | 3 |  |



Reconciliation of serial numbers in bin 2


| Bin 1 | Bin 2 | Out Area |
| System Sl. No. | Physical Sl. No. | System Sl. No. | Physical Sl. No. | Physical Sl. No. |
| 4 | 4 | 1 | 1 |  |
| 5 | 5 | 2 | 2 |  |
| 6 | 6 | 3 | 3 |  |


- Serial numbers  1, 2, and 3 are brought into bin 2 from the OUT area by way of a credit  memo.
- Variance for  bin 2 is zero.



{:.see_also}
See also
: [Impact  of Quantity Adjustment]({{site.wm_baseurl}}/inv-adj/stock-count/impact-of-quantity-adjustment/impact_of_quantity_adjustment.html)
