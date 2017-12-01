---
title: Back-end Processes - Generate Serial Numbers
---

# Back-end Processes


The following back-end processes occur when serial numbers are generated  for items being returned:

- On a POS Invoice  such quantity is prefixed with a negative sign.
- Serial numbers  are created for the specified units of the item and the item is assigned  to the default ‘Out’ stock area.
- When you save  the invoice, the item is transferred to a ‘Stock’ type of stock area.



{:.see_also}
See also
: [Generate  Serial Numbers]({{site.pos_baseurl}}/misc/generate_serial_numbers_pos_inv_option.html)
