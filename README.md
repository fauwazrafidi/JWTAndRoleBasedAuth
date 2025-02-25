# JWTAndRoleBasedAuth
<!-- Project Title: JWTAndRoleBasedAuth -->

Authentication that uses JWT Token and Microsoft Identity
<!-- Brief description of the project -->

## Table of Contents
<!-- Helps users quickly navigate through the README -->
- [About](#about)
- [Installation](#installation)
- [Usage](#usage)
- [License](#license)
- [Contact](#contact)
- [Acknowledgements](#acknowledgements)

## About
JWTAndRoleBasedAuth is a project designed to implement authentication using JWT tokens in combination with Microsoft Identity.  
<!-- Provide additional context if necessary, such as target platforms or key benefits -->

## Installation
Follow these steps to set up the project locally:

1. **Change the Connection String:**  
   Modify the connection string in your configuration file (e.g., `appsettings.json`) to point to your desired database.  
   <!-- Ensure that the connection string is correctly updated for your environment -->

2. **Update the Database:**  
   Open the Package Manager Console, set the default project to **Infrastructure**, and run:
   ```powershell
   Update-Database
