makestatic
==========

A Windows utility to generate static HTML from dynamic PHP sites.

You must be able to host the dynamic PHP version of your site to use makestatic, even if it is only hosted locally to your computer. This requires you to install PHP and a webserver on your computer.
Makestatic will copy the generated HTML to a destination folder on your computer for you to upload to your webserver.
Static HTML is sometimes preferable to PHP because it is faster (reduces server-side processing) and more compatible (eg with Github Pages, which does not support server-side PHP).

==========
To use, enter the root URL of the static version of the static version of the site.

	eg the root of the site with these pages
		127.0.0.1/index.php
		127.0.0.1/help.php
	is 127.0.0.1
	
	and the root of the site with these pages
		example.com/index.php
		example.com/hello.php
	is example.com

Then click 'Pick dynamic folder' to select the folder containing the PHP files on your computer.

Then click 'Pick static folder' to select the folder containing the HTML files on your computer. If they do not exist yet, create blank HTML files with names that match the PHP files (except the extension).

The selected PHP files will appear in the left hand listbox and the selected HTML files will appear in the right hand listbox. Only files that appear in both boxes will be affected.

Press continue to copy the generated HTML to the HTML files selected.

==========

You can load and save configurations with the buttons at the bottom, to save time when copying the same websites multiple times (eg after updating the PHP version).

A folder will be created in %APPDATA% called makestatic. This folder will contain plaintext text files specifiying details of saved configurations.
