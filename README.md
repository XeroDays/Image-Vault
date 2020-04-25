# Image-Vault
This is Open Source Image Vault program just for final year mini test project

# Summary
Program is bassically designed for locking image files from computer directory.
Just drag and Drop file to the Form and it will do the rest.

Features:
  - Scifi UI.
  - Secure images.
  - Strong Encryption Algorithm.
  - Easy to Use.
  - Remove File from Original Place.
  - Locked Files Gallary.
  - Secure Gallery Data Transaction.
  
  
  # Dependencies
  - .Net 4.5  
  
 # How it Locks:
  - Take Images when you drop a folder.
  - Move the Image to Document/ImageVault Folder.
  - Rename the File with a GUID key. (Globally Unique Identifier)
  - Removes the Extension.
  - Store Record info in SQLite db for:
    - Original File Location
    - VaultFolder File Name (GUID)
 
 # How it Un-Locks:
  - User Click Restore on Selected Images from Gallary.
  - Get GUID from Selected Images.
  - Search in SQLite database for Original File Paths Where GUID = 'Selected GUID'
  - Move back the File from VaultFolder to Original Path.
  - Add its Extension back to it.
 
