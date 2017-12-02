---
title: Ex. Difference
---


This field displays the difference between the Balance field and the  Balance @ Ex. Rate field. In other words, the field displays the gain  or loss on the outstanding balance of the multi-currency order document  due to the difference between the current exchange rate and the exchange  rate used when the deposit was accepted.


Keep in mind that as the applicable current exchange rate changes, the  Ex. Difference value changes as well to reflect the adjustment to the  remaining balance in the base currency. You use this value only to estimate  what the gain or loss will be. The actual accounting entries are made  only after you complete the final document.


Another way to view the gain or loss is to assess the strength of the  base currency against the document currency. Use the table below to determine  whether the exchange rate creates a gain or loss on the balance due for  a multi-currency order document.


| Document | Equation | Gain/Loss |
| Sales order or debit order | Balance < Exc. Rate Balance | Gain |
| Sales order or debit order | Balance > Exc. Rate Balance | Loss |
| Purchase order or credit order | Balance > Exc. Rate Balance | Gain |
| Purchase order or credit order | Balance < Exc. Rate Balance | Loss |



After you complete the final document, the system creates an accounting  entry for the gain or loss in the applicable accounting journal. Refer  to the **Receipts in Foreign Currency**  and **Payments in Foreign Currency**  topics for information on the Gain/Loss accounting entries. Refer to the  **Calculation of Foreign Exchange Gains 
 and Losses** topic for a detailed example.
