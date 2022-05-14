package UnicodeFileToHtmlTextConverter;

use strict;
use warnings;

use lib 'lib/UnicodeFileToHtmlTextConverter';

require HttpUtility;

sub new {
    my ( $class, $fullFilenameWithPath ) = @_;
    my $self = {
        fullFilenameWithPath => $fullFilenameWithPath
    };

    bless $self, $class;

    return $self;
}

sub getFileName {
    my ( $self ) = @_;

    return $self->{fullFilenameWithPath};
}

sub convertToHtml {
    my ( $self ) = @_;

    open(my $fileHandle, '<:encoding(UTF-8)', $self->{fullFilenameWithPath})
        or die "Can't open file '$self->{fullFilenameWithPath}' $!";

    my $html = "";
    
    while (my $row = <$fileHandle>) {
        chomp $row;

        $html = $html . HttpUtility->htmlEncode($row);
        $html = $html . "<br />";
    }
    
    return $html;
}

1;