---
title: Cost Determination of Serialized Items in case of Sales Orders
---

# Cost Determination of Serialized Items in case of Sales Orders


For serialized items, **Everest**  calculates the **Actual/Average Cost**  in the **Pricing Analysis** browser  based on the following conditions:

- When items  are fully committed in the sales order, **Everest**  calculates the **Actual/Average cost**  based on the average of the actual cost of serial numbers committed.
- If items are  partially committed, the **Actual/Average 
 cost** is equal to the (Sum of actual cost of serial numbers)+(current  average cost of the item X quantity not committed)/total quantity on order.
- If no items  are committed, the **Actual/Average cost**  displayed is the current average cost of the item.



When the analysis is by **Average Cost 
 (previous document save)**, then the **Actual/Average****Cost** is determined as follows:

- When items  are fully committed, the **Actual/Average 
 Cost** is the average of the actual cost of serial numbers committed.
- When the items  are partially committed, it is equal to the (Sum of actual cost of serial  numbers)+( last saved average cost of the item X quantity not committed)/total  quantity on order.
- If no items  are committed, it is the last saved average cost of the item.

