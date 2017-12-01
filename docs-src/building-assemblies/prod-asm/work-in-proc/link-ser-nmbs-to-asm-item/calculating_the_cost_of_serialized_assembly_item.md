---
title: Calculating the cost of Serialized Assembly Item
---

# Calculating the cost of Serialized Assembly Item


The unit cost of the serialized assembly item will be the sum of the  following costs if the **Link Serial No.**  option is used:

- Serialized item  - Actual cost of the serialized item linked to the assembly item.
- Auto-serialized  item - Actual cost of the auto-serialized item linked to the assembly  item if all the auto-serialized items are linked. If all the auto-serialized  items are not linked, then the actual cost of all input auto-serialized  items used in the assembly, divided by the required output.
- Inventoried item  - Actual cost of all input items used in assembly/required output.
- Non-Inventoried  item - Actual cost of all input items used in assembly/required output.



{:.example}
The following table shows how the cost of the assembly item Compaq computer  is arrived at, when you link individual item serial numbers to it.


The input serial numbers are linked to the assembly-serialized item  and the assembly serial numbers are 501, 502, 503.


Input items for the assembly item:


| Item | Item type | Quantity | Cost/unit | Actual cost |
| Monitor | Serialized | 3 | SL# - 101 – $ 105<br/><br/><br/>SL# - 102 -  $  110<br/><br/><br/>SL# - 103 -  $  115 | $ 330 |
| Hard drive | Auto-Serialized | 3 | SL# - 111 – $ 150<br/><br/><br/>SL# - 112 -  $  155<br/><br/><br/>SL# - 113 -  $  145 | $ 450 |
| Key board | Inventoried | 3 | $ 10 |  |
| Labor | Non- Inventoried | 3 | $ 50 |  |
| Total |  |  |  | $  960 |



{:.note}
In the above cost calculation method, the cost per unit will be 960/3  = $320.

- Calculation  of the cost per unit of the assembly item if the input serialized and  auto-serialized items [are  linked]({{site.ba_baseurl}}/misc/calculation_if_items_are_linked_link_serial_nos..html).
- Calculation  of the cost per unit of the assembly item if all input serialized items  are linked but auto-serialized items are [not  linked]({{site.ba_baseurl}}/misc/calculation_if_items_are_not_linked.html).



Cost calculation details:


The cost per unit of the assembly item will be the sum of the following  costs

- Actual cost  of the serialized item linked to the assembly item.
- Actual cost  of the auto-serialized item linked to the assembly item. If all auto-serialized  items are not linked, then the actual cost of all input items used in  the assembly/required output
- Actual cost  of inventoried items used in the assembly/required output
- Actual cost  of non-inventoried items used in the assembly/required output



1. In the above example, the cost per unit of the assembly item will  be the sum of the following cost

- Cost of Monitor  and Hard drive allocated to each unit of assembly item = Actual cost of  the monitor and hard drive linked to the assembly item.
- Cost of key  board allocated to each unit of assembly item = Actual cost / Required  output = 30/3 =10
- Cost of labor  allocated to each unit of assembly item = Actual cost / Required output  = 150/3 = 50



2. If the **Link Serial No.** option  is NOT used, the calculation of the cost per unit for the assembly item  is **Actual cost/Required** output.  The actual cost includes the cost of inventoried, serialized, auto-serialized  and non-inventoried items that are used in the assembly. The cost per  unit of the assembly item is calculated as below:

- Serialized  item - Actual cost of the serialized items, which is the sum of the serialized  cost used in the work order.
- Auto-serialized  item - Actual cost of the auto-serialized items, which is the sum of the  serialized cost used in the work order.
- Inventoried  item - Actual cost of all input items used in assembly
- Non-Inventoried  item - Actual cost of all input items used in assembly



The total actual cost is divided by the required output, to arrive at  the cost per unit of the assembly item.


{:.note}
- All input serialized  items must be linked to the assembly item, if the **Link 
 Serial No.** option is used.
- It is not mandatory  to link the inventoried items, as the cost of each inventoried item that  is used in the work order is the same.
- It is not mandatory  to link the auto-serialized items as the serial numbers that are used  in the work order might not be the serial numbers that are actually used  in the assembly item.
- Only if ALL  the auto-serialized items used in the assembly are linked, the cost of  the input auto serial numbers will be considered for the purpose of calculation  of the cost of the assembly serial number. If ALL the auto-serialized  items are NOT linked, then the average cost of the serial numbers used  will be considered for the purpose of calculation of the cost of the assembly  serial number.


{:.see_also}
See also
: [Linking Serial  Numbers]({{site.ba_baseurl}}/prod-asm/work-in-proc/link-ser-nmbs-to-asm-item/linking_serial_numbers.html)
