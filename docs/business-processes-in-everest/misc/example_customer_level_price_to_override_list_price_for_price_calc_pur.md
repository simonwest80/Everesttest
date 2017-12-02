---
title: Example - Customer level price to override list price for price calculation
---

# Example - Customer level price to override list price for price calculation


{:.example}
The following prices are defined for an item:


| Price Type | Amount |
| List Price | $100 |
| Customer Level Price | $110 |
| Quantity Pricing | $115 |
| Promotional Pricing | $105 |
| Special Pricing | $120 |



**Option Unchecked**
: If this option is unchecked, then the Sales Price  is $100. This is lowest price of all the price types.


| Price Type | Amount |
| List Price | $100 |
| Customer Level Price | $110 |
| Quantity Pricing | $115 |
| Promotional Pricing | $105 |
| Special Pricing | $120 |



**Option Selected – Customer Level Price is Available**
: If this option is selected and a Customer Level  price is available, then the Sales Price is $105. In this case, the Promotional  price is the lowest price since the list price is excluded. Only the Customer  Level price, Quantity pricing, Promotional pricing, and Special pricing  are considered when determining sales price.


| Price Type | Amount |
| Customer Level Price | $110 |
| Quantity Pricing | $115 |
| Promotional Pricing | $105 |
| Special Pricing | $120 |



**Options Selected – Customer Level Price is Not  Available**
: If this option is selected but a Customer Level  price is not available for the item, then the Sales Price is $100. In  this case, the List price is the lowest since only List price, Quantity  pricing, Promotional pricing and Special pricing are considered when determining  sales price.


| Price Type | Amount |
| List Price | $100 |
| Customer Level Price | N/A |
| Quantity Pricing | $115 |
| Promotional Pricing | $105 |
| Special Pricing | $120 |



{:.see_also}
See also
: [Customer  level price to override list price for price calculation]({{site.bp_baseurl}}/misc/customer_level_price_to_override_list_price_for_price_calculation.html)
