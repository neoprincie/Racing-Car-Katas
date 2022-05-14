use strict;
use warnings;

use Test::More 0.96;

use lib 'lib/UnicodeFileToHtmlTextConverter';

require UnicodeFileToHtmlTextConverter;

subtest 'foobar' => sub {
    my $converter = new UnicodeFileToHtmlTextConverter("test/UnicodeFileToHtmlTextConverter/foobar.txt");

    is($converter->getFileName(), "fixme");
};

done_testing();