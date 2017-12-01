---
title: Prompt method for selecting a stock bin when auto-serializing sales document
---


Specify a prompt method to select a stock area/bin when auto-serializing  sales documents. When an auto-serialized item is sold, **Everest**  automatically assigns quantities in the selected stock area to the sales  document.


| Option | **Description** |
| Once for all items | Displays the stock area/bin list. You can select the stock area/bin  from which all auto-serialized items in the document should be shipped. |
| Each item | Displays the stock area/bin list when entering quantities shipped or  committed for each auto-serialized item. |
| None | Automatically uses the stock bin defined in the **Workstation <br/> Settings** defined for auto-serializing items (path: **File <br/> &gt; Setup &gt; Preferences &gt; Workstation Settings &gt; Stock Bins&gt; <br/> Auto Serialize Items/Inventory Adjustments**). If stock areas are  not defined in the **Workstation Settings**,  **Everest** automatically uses the  default stock area defined for receiving items on **Purchase <br/> Receipts/Invoices** in the **Location**  profile. |

