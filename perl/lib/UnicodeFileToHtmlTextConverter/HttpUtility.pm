package HttpUtility;

use strict;
use warnings;

sub htmlEncode {
    my ( $class, $line ) = @_;

    $line =~ s/</&lt;/;
    $line =~ s/>/&gt;/;
    $line =~ s/&/&amp;/;
    $line =~ s/"/&quot;/;
    $line =~ s/'/&quot;/;

    return $line;
}

1;