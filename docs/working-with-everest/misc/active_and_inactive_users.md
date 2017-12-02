---
title: Active and Inactive Users
---

# Active and Inactive Users


**Active User**
: Users who are using **Everest**  are active users.


**Inactive Users**
: Inactive users are those users who get disconnected  while using **Everest**. The reasons  for disconnecting could range from power failure to crashing out of the  system.
: **Everest**  checks for all inactive users (this is a back end process) at an interval  of 180 seconds and removes the [locks]({{site.wwe_baseurl}}/misc/list_semaphore_locks.html)  from these users. This is checked at the server from where all the users  are accessing **Everest**.


{:.see_also}
See also
: [The **Logged-in Users** Browser]({{site.wwe_baseurl}}/misc/the_logged_in_users_browser.html)
