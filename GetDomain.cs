using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class GetDomain
    {
        public string GetDomainFromUrl(Uri Url)
        {
            if (Url == null) return null;

            string hostWithoutWWW = Url.Host.Replace("www.", "");

            if (hostWithoutWWW.Split('.').Length == 1)
            {
                return hostWithoutWWW;
            }
         
            var dotBits = hostWithoutWWW.Split('.');
            List<string> tlds = new List<string>();
            tlds.Add("ac");
            tlds.Add("ad");
            tlds.Add("ae");
            tlds.Add("aero");
            tlds.Add("af");
            tlds.Add("ag");
            tlds.Add("ah");
            tlds.Add("ai");
            tlds.Add("al");
            tlds.Add("am");
            tlds.Add("an");
            tlds.Add("ao");
            tlds.Add("aq");
            tlds.Add("ar");
            tlds.Add("arpa");
            tlds.Add("as");
            tlds.Add("at");
            tlds.Add("au");
            tlds.Add("aw");
            tlds.Add("ax");
            tlds.Add("az");
            tlds.Add("ba");
            tlds.Add("bb");
            tlds.Add("bd");
            tlds.Add("be");
            tlds.Add("bf");
            tlds.Add("bg");
            tlds.Add("bh");
            tlds.Add("bi");
            tlds.Add("biz");
            tlds.Add("bj");
            tlds.Add("bm");
            tlds.Add("bn");
            tlds.Add("bo");
            tlds.Add("br");
            tlds.Add("bs");
            tlds.Add("bt");
            tlds.Add("bv");
            tlds.Add("bw");
            tlds.Add("by");
            tlds.Add("bz");
            tlds.Add("ca");
            tlds.Add("cat");
            tlds.Add("cc");
            tlds.Add("cd");
            tlds.Add("cf");
            tlds.Add("cg");
            tlds.Add("ch");
            tlds.Add("ci");
            tlds.Add("ck");
            tlds.Add("cl");
            tlds.Add("cm");
            tlds.Add("cn");
            tlds.Add("co");
            tlds.Add("com");
            tlds.Add("coop");
            tlds.Add("cq");
            tlds.Add("cr");
            tlds.Add("cu");
            tlds.Add("cv");
            tlds.Add("cx");
            tlds.Add("cy");
            tlds.Add("cz");
            tlds.Add("de");
            tlds.Add("dj");
            tlds.Add("dk");
            tlds.Add("dm");
            tlds.Add("do");
            tlds.Add("dz");
            tlds.Add("ec");
            tlds.Add("edu");
            tlds.Add("ee");
            tlds.Add("eg");
            tlds.Add("er");
            tlds.Add("es");
            tlds.Add("et");
            tlds.Add("eu");
            tlds.Add("fi");
            tlds.Add("fj");
            tlds.Add("fk");
            tlds.Add("fm");
            tlds.Add("fo");
            tlds.Add("fr");
            tlds.Add("ga");
            tlds.Add("gb");
            tlds.Add("gd");
            tlds.Add("ge");
            tlds.Add("gf");
            tlds.Add("gg");
            tlds.Add("gh");
            tlds.Add("gi");
            tlds.Add("gl");
            tlds.Add("gm");
            tlds.Add("gn");
            tlds.Add("gov");
            tlds.Add("gp");
            tlds.Add("gq");
            tlds.Add("gr");
            tlds.Add("gs");
            tlds.Add("gt");
            tlds.Add("gu");
            tlds.Add("gw");
            tlds.Add("gx");
            tlds.Add("gy");
            tlds.Add("gz");
            tlds.Add("ha");
            tlds.Add("hb");
            tlds.Add("he");
            tlds.Add("hi");
            tlds.Add("hk");
            tlds.Add("hl");
            tlds.Add("hm");
            tlds.Add("hn");
            tlds.Add("hr");
            tlds.Add("ht");
            tlds.Add("hu");
            tlds.Add("id");
            tlds.Add("ie");
            tlds.Add("il");
            tlds.Add("im");
            tlds.Add("in");
            tlds.Add("info");
            tlds.Add("int");
            tlds.Add("io");
            tlds.Add("iq");
            tlds.Add("ir");
            tlds.Add("is");
            tlds.Add("it");
            tlds.Add("je");
            tlds.Add("jl");
            tlds.Add("jm");
            tlds.Add("jo");
            tlds.Add("jobs");
            tlds.Add("jp");
            tlds.Add("js");
            tlds.Add("jx");
            tlds.Add("ke");
            tlds.Add("kg");
            tlds.Add("kh");
            tlds.Add("ki");
            tlds.Add("km");
            tlds.Add("kn");
            tlds.Add("kr");
            tlds.Add("kw");
            tlds.Add("ky");
            tlds.Add("kz");
            tlds.Add("la");
            tlds.Add("lb");
            tlds.Add("lc");
            tlds.Add("li");
            tlds.Add("lk");
            tlds.Add("ln");
            tlds.Add("lr");
            tlds.Add("ls");
            tlds.Add("lt");
            tlds.Add("lu");
            tlds.Add("lv");
            tlds.Add("ly");
            tlds.Add("ma");
            tlds.Add("mc");
            tlds.Add("md");
            tlds.Add("mg");
            tlds.Add("mh");
            tlds.Add("mil");
            tlds.Add("mk");
            tlds.Add("ml");
            tlds.Add("mm");
            tlds.Add("mn");
            tlds.Add("mo");
            tlds.Add("mobi");
            tlds.Add("mp");
            tlds.Add("mq");
            tlds.Add("mr");
            tlds.Add("ms");
            tlds.Add("mt");
            tlds.Add("mu");
            tlds.Add("museum");
            tlds.Add("mv");
            tlds.Add("mw");
            tlds.Add("mx");
            tlds.Add("my");
            tlds.Add("mz");
            tlds.Add("na");
            tlds.Add("name");
            tlds.Add("nc");
            tlds.Add("ne");
            tlds.Add("net");
            tlds.Add("nf");
            tlds.Add("ng");
            tlds.Add("ni");
            tlds.Add("nl");
            tlds.Add("nm");
            tlds.Add("no");
            tlds.Add("np");
            tlds.Add("nr");
            tlds.Add("nu");
            tlds.Add("nx");
            tlds.Add("nz");
            tlds.Add("om");
            tlds.Add("org");
            tlds.Add("pa");
            tlds.Add("pe");
            tlds.Add("pf");
            tlds.Add("pg");
            tlds.Add("ph");
            tlds.Add("pk");
            tlds.Add("pl");
            tlds.Add("pm");
            tlds.Add("pn");
            tlds.Add("pr");
            tlds.Add("pro");
            tlds.Add("ps");
            tlds.Add("pt");
            tlds.Add("pw");
            tlds.Add("py");
            tlds.Add("qa");
            tlds.Add("qh");
            tlds.Add("re");
            tlds.Add("ro");
            tlds.Add("ru");
            tlds.Add("rw");
            tlds.Add("sa");
            tlds.Add("sb");
            tlds.Add("sc");
            tlds.Add("sd");
            tlds.Add("se");
            tlds.Add("sg");
            tlds.Add("sh");
            tlds.Add("si");
            tlds.Add("sj");
            tlds.Add("sk");
            tlds.Add("sl");
            tlds.Add("sm");
            tlds.Add("so");
            tlds.Add("sr");
            tlds.Add("st");
            tlds.Add("su");
            tlds.Add("sv");
            tlds.Add("sy");
            tlds.Add("sz");
            tlds.Add("tc");
            tlds.Add("td");
            tlds.Add("tel");
            tlds.Add("tf");
            tlds.Add("tg");
            tlds.Add("th");
            tlds.Add("tk");
            tlds.Add("tl");
            tlds.Add("tm");
            tlds.Add("tn");
            tlds.Add("to");
            tlds.Add("tp");
            tlds.Add("tr");
            tlds.Add("travel");
            tlds.Add("tt");
            tlds.Add("tv");
            tlds.Add("tw");
            tlds.Add("tz");
            tlds.Add("ua");
            tlds.Add("ug");
            tlds.Add("uk");
            tlds.Add("um");
            tlds.Add("us");
            tlds.Add("uy");
            tlds.Add("uz");
            tlds.Add("va");
            tlds.Add("vc");
            tlds.Add("ve");
            tlds.Add("vg");
            tlds.Add("vi");
            tlds.Add("vn");
            tlds.Add("vu");
            tlds.Add("wf");
            tlds.Add("ws");
            tlds.Add("ye");
            tlds.Add("yt");
            tlds.Add("yu");
            tlds.Add("za");
            tlds.Add("zm");
            tlds.Add("zw");
            tlds.Add("sn");
            tlds.Add("sx");
            tlds.Add("tj");
            tlds.Add("xj");
            tlds.Add("xz");
            tlds.Add("yn");
            tlds.Add("zj");

            List<string> TLD = new List<string>();
            List<string> possibleDomain = new List<string>();

            for (int i = 0; i < dotBits.Length; i++)
            {
                if (tlds.Contains(dotBits[i]))
                {
                    TLD.Add(dotBits[i]);
                }
                else
                {
                    possibleDomain.Add(dotBits[i]);
                }
            }

            string domainName = possibleDomain.Last();

            StringBuilder builder = new StringBuilder();
            foreach (string tld in TLD) 
            {
                builder.Append(".").Append(tld); 
            }

            string domainResult = domainName + builder.ToString();


            return domainResult;
        }
    }
}