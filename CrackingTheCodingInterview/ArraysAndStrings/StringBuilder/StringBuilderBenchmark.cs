using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.ArraysAndStrings.StringBuilder
{
    public class StringBuilderBenchmark : BenchmarkBase
    {
        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi posuere." };
            yield return new object[] { "orem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque ac blandit nisl, vitae euismod risus. Nullam ex leo, pulvinar at ullamcorper sit amet, sagittis vitae diam. Ut rutrum, leo in mollis bibendum, ligula elit aliquam mi, nec auctor augue augue vel nisi. Mauris a elit lacus. Sed sodales ut eros." };
            yield return new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque accumsan augue eu quam egestas suscipit. Maecenas maximus finibus enim, vel commodo est egestas eget. Ut ultricies nibh id ipsum sagittis pharetra. Aenean odio velit, suscipit ac consectetur ac, ultrices ac nisi. Donec maximus lobortis vestibulum. Integer non leo elit. Ut vestibulum, massa non rutrum suscipit, metus eros suscipit tortor, vel semper est mi eget risus. Cras nunc ligula, mattis eget magna nec, euismod porttitor velit. Aliquam eget felis et mi rutrum fringilla sed at lectus. Cras placerat, quam congue pulvinar ultricies, mauris felis mollis justo, sit amet mollis est tellus." };
            yield return new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec magna purus, porta et tempus et, dictum sed sem. Quisque volutpat tristique libero, non pretium mauris elementum vitae. Vestibulum molestie id lacus non faucibus. Aenean mollis efficitur elementum. Donec congue erat at aliquet placerat. Suspendisse mi tellus, tincidunt id egestas id, commodo id lorem. Curabitur ut mauris sit amet ipsum feugiat consectetur a a nunc. Curabitur placerat, ligula vel tempor congue, ex quam faucibus velit, eget dictum augue velit sed tortor. Integer imperdiet, eros et fermentum semper, enim leo tempus odio, sit amet hendrerit leo eros eu metus. Pellentesque in justo mi. Pellentesque ultrices vulputate elit, nec condimentum dui consequat ac. Etiam ac lorem viverra, auctor nisi a, tempus diam. Nam id libero interdum, placerat lorem ac, placerat ipsum. Suspendisse potenti. Cras volutpat volutpat euismod. Nulla rhoncus diam congue lectus varius, quis convallis urna facilisis. Duis non sapien purus. Cras ultricies vehicula erat. Aliquam eu laoreet nisi, non imperdiet erat. Etiam nec mauris nunc. Aliquam erat volutpat. Vivamus dapibus velit id luctus posuere. Morbi ac porta nisl. Suspendisse a ligula lorem. Sed justo dolor, tempor et diam et, vestibulum mollis sapien. Nunc pharetra feugiat turpis. Praesent fermentum nunc id eros vulputate eleifend. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Aliquam erat volutpat. Curabitur id sem bibendum, molestie augue non, aliquam est. Donec eleifend mollis lectus ut aliquet. Fusce ut condimentum nunc, convallis gravida est. Aenean non lobortis ligula. Etiam finibus eget est molestie sagittis. Quisque ac porttitor risus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Sed sem ante, ultricies eget risus ut, aliquet mattis lorem. Pellentesque sed luctus quam. Fusce nec nunc sem. Vestibulum tincidunt ante tellus, in pellentesque sem fermentum suscipit. Nulla blandit massa id tincidunt dictum. Duis non risus nibh. Etiam molestie nunc et nisl suscipit, sed consequat ligula faucibus. Aliquam vel risus vel nunc posuere ultrices at eu massa. Ut elit est, molestie vel ex commodo, blandit finibus ipsum. Proin finibus accumsan purus. Sed vel maximus risus, ut auctor ante. Sed in odio magna. Pellentesque dictum eget ex mattis vestibulum. Donec porttitor placerat accumsan. Duis commodo eu tortor nec malesuada. Suspendisse dignissim eros nulla, quis volutpat orci finibus nec. Pellentesque iaculis erat in dui luctus mollis. In dictum arcu non auctor ornare. Cras quis lorem purus. Vestibulum consectetur eros diam, vel venenatis massa varius tincidunt. Proin sed sapien mollis, gravida mauris fermentum, blandit dui. Aenean in quam eros. Etiam dictum felis scelerisque neque vehicula, quis ornare lorem tincidunt. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce ornare gravida nisl. Mauris tincidunt dolor ipsum, non tincidunt ex consequat eu. Sed lectus turpis, rutrum a turpis quis, faucibus dapibus velit. Phasellus sodales ex sed tempor hendrerit. Maecenas posuere dictum ex at sodales. Duis fermentum, justo quis lacinia varius, lacus nisl facilisis nunc, vitae bibendum massa magna a nibh. Sed congue magna vitae consectetur aliquet. Nulla semper eget turpis et ornare. Vivamus non." };
            yield return new object[] { @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam in purus sed quam commodo efficitur sed id lacus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean porta augue non velit fringilla maximus. Etiam eu turpis at turpis interdum pulvinar non eu dui. Mauris eu sagittis est. Vivamus nec lacinia neque, non rutrum massa. Praesent euismod malesuada volutpat. Morbi elementum eu turpis vitae dapibus. Nullam dapibus ipsum ac metus suscipit molestie. Mauris pharetra non ex at lacinia.

Fusce diam ligula, interdum sit amet libero id, tincidunt lobortis nulla. Vestibulum nec laoreet felis. Mauris sit amet eros pharetra, suscipit eros vel, bibendum urna. Duis suscipit id quam et vehicula. Duis et arcu faucibus nisl cursus pellentesque quis ac risus. Donec ac accumsan nisl. Vestibulum metus lorem, semper sed cursus luctus, eleifend ut quam. Ut finibus interdum maximus. Nulla tincidunt nunc pharetra, iaculis justo id, vestibulum quam. Praesent maximus eu nibh nec lobortis. Donec vulputate nisi vitae sem condimentum maximus. Nunc venenatis, dui eu molestie facilisis, libero neque efficitur turpis, eu ornare velit purus vitae erat. Vestibulum vulputate eros ut blandit vehicula. In hac habitasse platea dictumst.

Nunc eu luctus mi, facilisis ultricies nunc. Integer at porta eros. Etiam pellentesque sem lacus, eu tempus ligula consequat et. Nam metus ipsum, iaculis et ultricies ac, tincidunt vitae velit. Pellentesque id nibh in velit ullamcorper dictum. Vestibulum urna ex, elementum sed ipsum vel, facilisis venenatis leo. Fusce volutpat, diam non laoreet pharetra, velit mi pellentesque diam, eu gravida lectus sem vitae elit. Quisque semper felis ut odio bibendum facilisis. Proin molestie magna sit amet mattis convallis. Sed nec arcu velit. Suspendisse ornare diam id lacus convallis elementum. Mauris et libero lorem. Nulla efficitur maximus malesuada. Nullam efficitur accumsan felis rhoncus aliquet.

Morbi interdum diam non urna molestie malesuada. Ut lacus odio, malesuada a pellentesque vel, sagittis a erat. Sed aliquam, felis a congue venenatis, leo enim sollicitudin nisi, non posuere ante tortor vitae dui. Donec vel elit odio. Morbi maximus urna quam, nec efficitur enim hendrerit eu. Aenean bibendum tellus sed purus finibus hendrerit eu at tortor. In tincidunt felis quis arcu sagittis, vitae placerat enim fermentum. Nulla felis velit, interdum eget eros molestie, volutpat efficitur enim. Mauris vitae quam vehicula, ultricies arcu congue, rutrum velit.

Curabitur sed justo tempus, efficitur odio at, rhoncus lacus. Sed laoreet rhoncus lacinia. Pellentesque suscipit, nulla gravida cursus condimentum, urna dui hendrerit justo, ac hendrerit turpis mauris ac urna. Integer mattis consectetur quam, et dignissim mauris dignissim tempus. Ut sagittis facilisis tincidunt. Aliquam vel pretium dolor, in mattis nibh. Nulla sit amet justo dolor. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam dui nibh, sodales eu orci eget, condimentum sagittis nisl. Fusce augue sem, pharetra et erat vitae, cursus faucibus arcu. Duis non ultrices purus. Maecenas quis dolor et turpis sodales lacinia a a enim. Praesent semper urna at orci lobortis, vel rhoncus justo pretium.

Morbi rutrum, felis in scelerisque rutrum, sapien turpis iaculis sem, at consectetur diam nulla eu lacus. Curabitur ornare nisl sit amet scelerisque gravida. Pellentesque vel dictum metus, vehicula fermentum massa. Integer justo lorem, dignissim et convallis ut, lobortis sit amet risus. In hac habitasse platea dictumst. Vestibulum non dui id elit maximus scelerisque convallis eu nisl. Nunc sem odio, consequat ac turpis vel, laoreet pharetra ante. Integer vehicula nisl sit amet auctor rutrum. Sed mauris tellus, accumsan id suscipit quis, posuere et nibh. Fusce euismod nisi nunc, sed semper felis laoreet egestas. Sed lacus odio, hendrerit vitae consequat a, cursus sed magna. In at diam fringilla, ultrices augue eget, condimentum nunc. Nunc eget elementum eros. Aliquam laoreet felis nisi, sit amet rutrum libero cursus non. Mauris tristique enim a enim suscipit, sed elementum massa dictum. Etiam id eros risus.

Mauris dictum justo sed nisi tempus commodo. Vestibulum id eros at tortor egestas molestie. Vivamus luctus magna sed quam accumsan, posuere finibus metus fringilla. Ut dictum rhoncus aliquam. Morbi non porta libero, non vestibulum ipsum. Curabitur ligula ipsum, scelerisque non ligula vitae, iaculis porta neque. Vestibulum vitae tellus sem.

Nulla facilisi. Donec hendrerit pellentesque leo non porta. Proin et dictum tellus. Phasellus id semper quam, ut porttitor enim. Quisque vel metus sit amet nibh aliquam tincidunt sit amet a metus. Fusce gravida congue turpis. Donec laoreet, metus in suscipit tempus, leo ex vestibulum arcu, ut vulputate lacus urna sed libero. Etiam viverra augue in lobortis placerat. Aliquam erat volutpat.

Nullam augue sapien, laoreet et hendrerit accumsan, ultricies id orci. Etiam mollis nibh sed magna finibus, et eleifend nisi accumsan. Nullam aliquet, nunc ultricies consequat ornare, dui sem congue neque, eu consectetur odio urna sed diam. Vestibulum scelerisque finibus blandit. Aenean quis velit sed purus tincidunt pellentesque. Suspendisse dapibus tortor eu ligula dictum varius. Morbi et augue euismod, auctor purus quis, vulputate nunc. Ut leo orci, viverra ac semper a, lacinia a mauris. Maecenas blandit risus vel imperdiet semper. Nam fermentum lobortis nibh ac blandit. Interdum et malesuada fames ac ante ipsum primis in faucibus. Maecenas varius sagittis metus, eget tincidunt odio tristique ac. Curabitur auctor felis gravida lorem gravida, in facilisis enim ornare. Curabitur in fringilla arcu. In risus nisl, condimentum nec tellus id, efficitur egestas erat. Proin mollis nisi nec nulla ultricies, in imperdiet velit mollis.

Interdum et malesuada fames ac ante ipsum primis in faucibus. Phasellus consequat eget mauris nec rutrum. Vestibulum nibh purus, pretium eu diam posuere, molestie commodo mi. Morbi non ex libero. Nullam commodo ligula lorem, eget faucibus magna finibus eget. Vestibulum sed rutrum tortor. Aenean venenatis mi libero, et auctor sem eleifend sed. Nulla non interdum lorem. Cras arcu erat, lacinia sed cursus vel, hendrerit a dolor. In semper est eget diam elementum, et hendrerit diam volutpat. Aenean vitae libero sed tortor sodales posuere sed et elit. Suspendisse vel condimentum leo. Nulla bibendum mollis nulla in volutpat.

Vivamus eget finibus metus. Nulla placerat lacus eu sem tempor varius. Donec vehicula suscipit imperdiet. Vivamus ullamcorper, orci sed vehicula dignissim, nisl ipsum vehicula purus, eget cursus nisi ipsum quis nibh. Ut iaculis, ligula ut." };
        }

        [Benchmark(Description = "System.Text.StringBuilder", Baseline = true)]
        [BenchmarkCategory("Append_Constructor")]
        [ArgumentsSource(nameof(Data))]
        public void Default_Append_Constructor(string data)
        {
            var sb = new System.Text.StringBuilder(data);
        }
        [Benchmark(Description = "MyStringBuilder", Baseline = true)]
        [BenchmarkCategory("Append_Constructor")]
        [ArgumentsSource(nameof(Data))]
        public void MyStringBuilder_Append_Constructor(string data)
        {
            var sb = new DataStructures.StringBuilder.MyStringBuilder(data);
        }


        [Benchmark(Description = "System.Text.StringBuilder", Baseline = true)]
        [BenchmarkCategory("Append")]
        [ArgumentsSource(nameof(Data))]
        public void Default_Append(string data)
        {
            var sb = new System.Text.StringBuilder();
            sb.Append(data);
        }
        [Benchmark(Description = "MyStringBuilder", Baseline = true)]
        [BenchmarkCategory("Append")]
        [ArgumentsSource(nameof(Data))]
        public void MyStringBuilder_Append(string data)
        {
            var sb = new DataStructures.StringBuilder.MyStringBuilder();
            sb.Append(data);
        }



        [Benchmark(Description = "System.Text.StringBuilder", Baseline = true)]
        [BenchmarkCategory("AppendLine")]
        [ArgumentsSource(nameof(Data))]
        public void Default_AppendLine(string data)
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine(data);
        }
        [Benchmark(Description = "MyStringBuilder", Baseline = true)]
        [BenchmarkCategory("AppendLine")]
        [ArgumentsSource(nameof(Data))]
        public void MyStringBuilder_AppendLine(string data)
        {
            var sb = new DataStructures.StringBuilder.MyStringBuilder();
            sb.AppendLine(data);
        }




        [Benchmark(Description = "System.Text.StringBuilder", Baseline = true)]
        [BenchmarkCategory("ToString")]
        [ArgumentsSource(nameof(Data))]
        public void Default_ToString(string data)
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine(data);
            var result = sb.ToString();
        }
        [Benchmark(Description = "MyStringBuilder", Baseline = true)]
        [BenchmarkCategory("ToString")]
        [ArgumentsSource(nameof(Data))]
        public void MyStringBuilder_ToString(string data)
        {
            var sb = new DataStructures.StringBuilder.MyStringBuilder();
            sb.AppendLine(data);
            var result = sb.ToString();
        }
    }
}
