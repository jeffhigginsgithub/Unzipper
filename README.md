# Unzipper
A simple tool for (only) unzipping archives.

Download [here](https://github.com/jeffhigginsgithub/Unzipper/blob/main/Unzipper.zip).

![alt text](https://github.com/jeffhigginsgithub/Unzipper/blob/main/Unzipper.png)

Some environments don't allow software to be installed if the user doesn't have local administrator permissions, and others won't allow software on a user's system if it's able to create encrypted files. This can cause problems when encrypted archives need to be extracted, as most (all?) free tools that can decrypt archives also have the ability to create encrypted archives.

This program will only unzip - no zipping. It supports regular, password-protected (both ZipCrypto and AES-256), and filename encrypted .zip, .7z, and .rar files. The interface is straight-forward so that it's simple to use. Additional options are:

* Context Menu entry for easy unzipping
* Choose between automatic creation of a destination subfolder (based on the name of the archive) or manually select a destination to extract the files
* Use of a password if required to extract the files
* Overwrite existing files or skip over them instead
* Open a new File Explorer window at the unzip location once finished

Cancellation of the extraction process is also supported.

Unzipper will check to see if the Context Menu item for supported file types already exists, and if not then creates it on startup. To manually add, update, or remove Unzipper to/from the File Explorer Context Menu, click the appropriate button found on the About form.

![alt text](https://github.com/jeffhigginsgithub/Unzipper/blob/main/UnzipperCM.png)

This tool makes use of the excellent [SharpCompress library](https://github.com/adamhathcock/sharpcompress) for C#.


v1.1:
* Add Context Menu item if it doesn't already exist on application startup 
* Added 'Remove from Context Menu' button on the About form
* Added supported file types '.tar' and '.gz'

v1.0
* Initial release
