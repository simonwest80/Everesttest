---
title: Back End Processes - Cancel a Debit Order
---

# Back End Processes - Cancel a Debit Order


When a debit order is canceled the following back end processes occur:

- The debit order  is converted to a debit quote.
- If the cancelled  debit order was originally converted from a quote, it is converted to  a debit quote with the number of the original quote.
- If the canceled  debit order was created without converting an existing debit quote, it  gets converted to a debit quote with the debit quote number assigned to  the debit order (when it was created).
- The sequence number  of the cancelled debit order is not available for further use in other  debit orders.
- The quantity ‘on  debit’ for the item reduces.

