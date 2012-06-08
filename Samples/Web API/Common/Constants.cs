﻿
namespace Thinktecture.Samples
{
    public static class Constants
    {
        public const string WebHost = "adfs.leastprivilege.vm";
        public const string SelfHost = "roadie:9000";
        public const string IdSrv = "identity.thinktecture.com";
        public const string ACS = "ttacssample.accesscontrol.windows.net";
        public const string ADFS = "adfs.leastprivilege.vm";

        public const string IdSrvSymmetricSigningKey = "Dc9Mpi3jbooUpBQpB/4R7XtUsa3D/ALSjTVvK8IUZbg=";
        public const string AcsSymmetricSigningKey = "yFvxu8Xkmo/xBSSPrzqZLSAiB4lgjR4PIi0Bn1RsUDI=";

        public const string Realm = "https://samples.thinktecture.com/webapisecurity/";
        public const string ServiceBaseAddressWebHost = "https://" + WebHost + "/webapisecurity/api/";
        public const string ServiceBaseAddressSelfHost = "http://" + SelfHost + "/services/api/";
    }
}