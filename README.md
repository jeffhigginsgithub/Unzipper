# Unzipper
A simple tool for (only) unzipping archives.

![alt text](https://github.com/jeffhigginsgithub/Unzipper/blob/main/Unzipper%20example.png)

Some environments don't allow software to be installed if the user doesn't have local administrator permissions, and others won't allow software on a user's system if it's able to create encrypted files. This can cause problems when encrypted archives need to be extracted, as most (all?) free tools that can decrypt archives also have the ability to create encrypted archives.

This program will only unzip - no zipping. It supports regular, password-protected (both ZipCrypto and AES-256), and filename encrypted .zip, .7z, and .rar files. The interface is straight-forward so that it's simple to use. Additional options are:

* Choose between automatic creation of a destination subfolder (based on the name of the archive) or manually select a destination to extract the files
* Use of a password if required to extract the files
* Overwrite existing files or skip over them instead
* Open a new File Explorer window at the unzip location once finished

Cancellation of the extraction process is also supported.

This tool makes use of the excellent [SharpCompress library](https://github.com/adamhathcock/sharpcompress) for C#.
