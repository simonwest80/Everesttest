---
title: Configure the Default Dashboard for Users
---

# Configure the Default Dashboard for Users


To manage your site content and limit the information available to selected  users, you can set the dashboard that each user sees at login.


{:.example}
You create multiple sub-sites with restricted  information and assign different users to each sub-site. The users can  then see the sub-site assigned to them and they can navigate to the root  (main) site.


![]({{site.db_baseurl}}/img/lens.gif) [Create  an Everest Advanced Dashboard Sub-Site]({{site.db_baseurl}}/share-point-services-basics-based-on-windows-network-users-/create_an_everest_advanced_dashboard_sub-site_ead.html)


{:.steps}
To configure the default dashboard for a  user, do the following:

- Open the **Users** browser (Path: **File**  > **Setup** > **Users**  > **Users**).
- Select the user  record to be modified and press **Enter**.  The User profile for the selected user is displayed.
- Click the **Miscellaneous** tab.
- In the **Dashboard**  field, select the user’s default dashboard. This is the dashboard that  the user sees at login. Depending upon your Dashboard Analytics license  type, you can select one of the following possible values in the table:



| Dashboard Field Values | What the User Sees | License Needed to View this Option |
| None | An Image Only – The toolbar is disabled | All licenses can view this option |
| Basic | Management Synopsis | Basic, Professional, and Enterprise |
| Professional | The Default Windows SharePoint Services site URL | Professional |
| Enterprise | The Default Windows SharePoint Services site URL | Enterprise |
| Custom | The URL entered in the User Profile – Miscellaneous  tab URL field | All licenses can view this option |


- If you select **Custom**, enter a valid URL in the **URL** field. Otherwise, the URL field  is display only and shows the URL or path being used for the user’s default  dashboard
- Click **Save**.  The user profile is updated with default dashboard information.



{:.see_also}
See also
: [Dashboard  User Interface]({{site.db_baseurl}}/dashboard-user-interface/dashboard_user_interface_ead.html)
