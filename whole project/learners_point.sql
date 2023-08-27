-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 19, 2022 at 09:22 PM
-- Server version: 10.4.20-MariaDB
-- PHP Version: 7.4.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `learners_point`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `Admin_ID` int(11) NOT NULL,
  `Name` varchar(15) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Phone` int(15) NOT NULL,
  `Password` varchar(20) NOT NULL,
  `imag` blob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`Admin_ID`, `Name`, `Email`, `Phone`, `Password`, `imag`) VALUES
(1, 'Tonima Islam', 'toni@gmail.com', 1879074212, 'tonima', 0x53797374656d2e44726177696e672e4269746d6170),
(2, 'Sanzida Akter', 'sanzida@gmail.com', 1824578659, 'sanzida', ''),
(3, 'Rafiqul Islam', 'rafiquljakir@gmail.com', 1879074212, 'rafiquljakir', 0x89504e470d0a1a0a0000000d49484452000001680000016808060000007ae561d5000000206348524d00007a25000080830000f9ff000080e9000075300000ea6000003a980000176f925fc546000000097048597300000b0c00000b0c013f4022c800002b6c49444154785eeddd59961c4796def156894381034052bd0de9482a8e60e9682778909a334876eb8d3be00ea4876e1538812058a4ba97c1c307aca25e812550df97b0001399ff9b199919ee6ee6fedd737ec7228d55b81e6ee6377c0a8fbffbedb7df2222a243d8191111cbc3ce8888581e764644c4f2b033222296879d1111b13cec8c8888e5616744442c0f3b23226279d8191111cbc3ce8888581e76561289a5e3d1c387cfb5f61979f6a833911828a8b656b0b3e2f8dbdffe1671502ab4371efcfacb5b76e7eefdf7e523f9f8d6175fde6d7ed4ffeeb743d1bff7affe374d793e974fe5b67c221f7939b44c2fea7f8bcb1b71590eaaad15ecac382869c45954ec5e6eaeab00baf07e7fe8a23b352def3d2f7bfb207953efe59afaf1fd46541c545b2bd8597150d20853d17a455e5521fbd07ba32a6adefbfd59ff0d8bdee8f4deeecb37f2958af63beac3f512b1e3a0da5ac1ce8a8392c636b920bb30f9b4808ad40feac342b6355a17dedbf62913ef71df541faebfd81e07d5d60a76561c9434b6c17bc72e382a40dfe96f2c4ec1b4cebef70799d69fcf6fdf501faee3583707d5d60a76561c9434d64b45e50315976ff51a0b4f5c8ed6e97def61fb434f7fe3ba8ff571506dad6067c54149631ddaf9e30fe4b6fec6c212d3d03aff3ca743d6cf41b5b5829d1507258d71f9905bdef621b8fec6e211f3d258fce0629d5321ebe3a0da5ac1ce8a8392c658b4e1bfa23d365fd84b51ee9cc6e8ae8f6af41ac732c6e2a0da5ac1ce8a839246ffdae98bdc6d31307fa0e634c8d81c545b2bd8597150d2e89736e8ff96a2bc3e1ad37b3e35e5a321fd8d631ffd71506dad6067c54149a33fbee8a41637ee58178df5ed14ea3138a8b656b0b3e2a0a4d187ec2d6f9bc6feaee640bed1d83107d5d60a76561c943496a58df2bfabc58d36b6497bd59fe42e90fe38a8b656b0b3e2a0a4313f6d7caf6923fc27bdc60d34c2dae98f7c19a6130eaaad15ecac382869cc477bcbfeaaf53dbdc60d3282b4d31f6fe935ceab9887836a6b053b2b0e4a1ad3d3c6f5676d64f7f51a37c0887d680e7d9742bd1c07d5d60a76561c9434a6a38de99dec31c7a1658f7a190eaaad15ecac3828691c9e369e9cca88c9b542fdb65ee33c8cc372506dad6067c54149e3707cf14f1b4dbe821db3d29ccba98f1938a8b656b0b3e2a0a47175ad30dfd56bdc8022e6a039f8ade662bef4321107d5d60a76561c9434aec6b742a9c50d266209ed3eea97f41ae76c5c8e836a6b053b2b0e4a1a97a343ca77d5e20612d1839c9f3e2c07d5d60a76561c94342ec6933ea73362149eab29d487e1a0da5ac1ce8a8392c6fe723a2346e50b89f956e2d538a8b656b0b3e2a0a4713eed81f839be38f12346a29d8c8fd4e23c8fb339a8b656b0b3e2a0a451f31e87f73cf41a277bc4887cda237bd317e7a0da5ac1ce8a839206d39ec6876a718247ac413b32c4f91fa739a8b656b0b3e2a0a4f134ed59e49ee6d88c766e3af74eefc141b5b5829d1507258ddfb5f373389123d62c777a9ccf41b5b5829d1507258d7c453bc2da3680db48a4402fa2ed39e0848dd8a29c9b660eaaad15ecac3828e996ddb97bff63b5384923b6ac6d1bb8dd6c95836a6b053b2b0e4aba45b97d2ee27cbe589e0b88bf73506dad6067c54149b746876ffee5649c9011719ab6993cca541c545b2bd8597150d22dc95d1a1197d3b61ddcaeb6c241b5b5829d150725dd021da6bda4c3b56ff51a275f449caf6d43b88d6d81836a6b053b2b0e4aba762ace37daed4338e922627fde967c0d47af717b5b3307d5d60a76561c9474cd720b5dc434dab685dbdd5a39a8b656b0b3e2a0a46b7527cfd28898d4d68ab4836a6b053b2b0e4aba46b9bf39621e5bba5fda41b5b5829d1507255d93470f1f5ebbf5c5975feb354ea68838bcad5c3c74506dad6067c54149d7c237d46ba2e42974110b6817e271db5c0b07d5d60a76561c94740d549c5f538b1327226685dbe81a38a8b656b0b3e2a0a4a3cb9d1a117dd10ed3dfabc5ed75640eaaad15ecac3828e9c8da5750719244c472d658a41d545b2bd8597150d251a938bfa9162747442c4fdba89f7b83dbef881c545b2bd8597150d21169e05f578b932222fab1a622eda0da5ac1ce8a83928e4603fe865a9c0c11d19fb6cde2f63c1207d5d60a76561c94742429ce11635a439176506dad6067c5414947a101ce39e78881691b1efab9d20eaaad15ecac3828e908dac0e2a047c43846bebbc341b5b5829d150725ed5d8a73c4ba8c5aa41d545b2bd8597150d29ea938e74b28112b34629176506dad6067c541497ba501ccd7b723d60db7fd5e39a8b656b0b3e2a0a43d52717e592d0d6844ac0bd6801e39a8b656b0b3e2a0a4bd51717eb13d198b0633225664a4a7e039a8b656b0b3e2a0a4bdd1807da316073322d647dbfc776ab11ef4c441b5b5829d150725ed497e0925629b46f8651607d5d60a76561c94b417f90dc1886d6b776d617de881836a6b053b2b0e4ada030d4cbe2518115d7fdbd041b5b5829d1507255d9a06244fa68b88271e3d7cf88a5aac174b72506dad6067c5414997a48178fed6175fded36b1ca888d89e5eefec70506dad6067c5414997a481f0af01e32045c476b5da807563290eaaad15ecac3828e952eedcbdff915a1c9c88885623b07e2cc141b5b5829d1507255d429eb11111fbe8e9a2a1836a6b053b2b0e4a3ab7470f1fde508b8311eba4c3d59fe4ae7ce5db297d6158ded05c7849fffdf8dcf057fcddbee0eb13fadfbce9ff9dfe3f1ff890b7f9c1ff666c47ab194fd5912538a8b656b0b3e2a0a473d306e66f0de140c43a688cbf57617ddb05579e2ac287a07ff339176e1770e5baab3e5c8e58078db16f24c0b9302707d5d60a76561c94744e5ad15fabc5418871b920fb7ca10ae66287a3fe20d0327cac65c91ef60a696c3f518b633f1707d5d60a76561c94742edea3528b2b3fc6e3a2ec3d58bdc6f15e9a96ed9db6e785cb1fe3d198de548be33d0707d5d60a76561c94740e3ed4558b2b3dc6a18277d7e7837d8a417fe358f746cbfaa2f7beb4ec3fea6f7c5f31141ce73938a8b656b0b3e2a0a473f086ad9656760ca0ed2d0fffabcc3e8ad37bc929908169fc163b1feda0da5ac1ce8a83924ecde705d5e2ca8ebe6963f84e45cd5fc5c7b11d552bd479e6f8a0347eefa8c5b19d92836a6b053b2b0e4a3aa59cda18938ad7dd35ec319fa715ea9ca71e906acbab6a715ca7e2a0da5ac1ce8a83924ec97b606a7105479f74c4d3d5b7b7e6d0ee10c0f5117d6a4740389e5371506dad6067c54149a7d236745cb9d19ff6618a63b905da23bbde367a5c3fd11f1d01cd7a5787836a6b053b2b0e4a3a054f76b5b852a33f4b9dd3eb515b17b89ea23f739eea70506dad6067c54149a790531b6358e2307104dae85fcbdef418e69cc30eaaad15ecac3828e9a1690fe45db5b832a31fedee1a1cc3782c77208d61ae234007d5d60a76561c947402b812a31f9ad0dd7e03b0375a57f906ec00e638d5e1a0da5ac1ce8a83921e92f6383e538b2b3096e7c3414de417f41ac72f984f79a8c5751a7d50edf95c2d8edfa138a8b656b0b3e2a0a487d23ec170e5c5f2549cef6a8c9ed16b1cbf389fd661ee99ee988e76267d5897836a6b053b2b0e4a7a2899bcfdd2d86cfa16ba43f2079d5a5ccfb12c8dcda4170c1d545b2bd8597150d243d027d79fd5e24a8b65b58282e31697d33ef0707dc7b2daf72f70dcaeca41b5b5829d1507253d105c59b1acec394f277bd2fd7af4f0e18b6a71dcaec241b5b5829d150725bdaa76721e57542cc7054413f559bdc6718babd33ace93f13aa49af4a95a1cb3ab70506dad6067c54149af221706fba4c2e1bb357241701e3806b12ccd7fdf7943e375690eaaad15ecac3828e955a810e4c260873439732bdd4c5a21c07188e5b45350386697e5a0da5ac1ce8a83925e5626669ff22594f9b5758ee311cb39f4b6e0a0da5ac1ce8a83925e960fa3d5e28a8965dcc9d7b717d3ee1ec0718965b41a85e375190eaaad15ecac3828e965e893294ffcea4c3bdd84e315f36887d5383eb18c56ab70bc2eca41b5b5829d150725bd8c560c7085c4321e3d7cf88a5a1caf9887c620bf20d49943eeb838a8b656b0b3e2a0a41795bde7fe684cfc401f1caf9897c6c20f91c7718a65684c0ef2157007d5d60a76561c94f4a2b2f7dc9776588d6315cbd098e49b861dd1781ce45cb4836a6b053b2b0e4a7a11d93be88f0eab5f528be3158bc2f18a651ce228d341b5b5829d150725bd087d12e59b531d99f2b90371351a9bfc106d470e71a4e9a0da5ac1ce8a8392ee2bf73df745132e776d74ae8d118e5fcc4f7bd16fa8c5b1da87836a6b053b2b0e4abaaf4cb6be5c75b2c5f4da61358e5fcc4f35ec4a0f0f73506dad6067c54149f7a1bde73c73a323579d68311f8d55bed0d511d5b21b6a71accee3a0da5ac1ce8a8392eee3ceddfbffa816df70cc2f7bcfe3c85e745f54cb2efdd3580eaaad15ecac3828e99ef0cdc6fcdaa9261aa3e8544e0ff6457bd1977a5eb4836a6b053b2b0e4a7a9ef689836f34e6d7f6c870aca24f1ab37cb9ab23aa69977a668d836a6b053b2b0e4aba077c93b1181aa3e81f8d652c87c6e84c0eaaad15ecac3828e959f4c9ffae5a7a73b180766f2d8e55f44d63e75ff9c0718df9b5a31a1cab8a836a6b053b2b0e4a7a965bf9624a572e7bee2c96a7b1bbae16c735e677993ba11c545b2bd8597150d24a6eadeb8b26549eb931388d616eb9ebc84577781c545b2bd8597150d28a0ec9726b5d477271707c6d0c717c637eaa711faac5b1220eaaad15ecac3828e919f04dc562688c623c34b6b1908bec453ba8b656b0b3e2a0a4449ff4796a5d477468fcad5a1cab184b4e73f445b56eef67453ba8b656b0b3e2a0a44493e8be5a7c4331bf8b1e8a45bf3496f9edc28e5ce4da8e836a6b053b2b0e4a7a52ae36f7a75db0c5f18ab1682cafa9c5718ec5e0589de4a0da5ac1ce8a83929e944ff82ee158c5b0688c6321fb9ee670506dad6067c541494fcae98dbeb47396385631268d697e12ab23fb9ee670506dad6067c541498fd3e1d70b6af14dc432da055b1caf1893c6d44f23c4f18ec5e0581de7a0da5ac1ce8a83921ed72e46d1c2c74272fe797d54a05f578be31dcb68a77671bc761c545b2bd8597150d2e3daae3ebe8158460af4fa684cffa016c73b96b1cfa94407d5d60a76561c94744793c6bf0e8d0b1fcbd0a4f1f5001caf185b1b5b1cf758866ae0cb6a71bccc41b5b5829d150725ddd161579e59db196dc47938ff4a696c73a1b033aa81673e4ec141b5b5829d150725dd69bbf8b8e0b10c8dc9376a71bc626c6d6c71dc63191a9333efe670506dad6067c54149adeddae342c772ee5cf2971fa27ff9be41b770bccc41b5b5829d150725b5b66b4f0b1b0bd2b8e416bb95ca1d537d6aa77a71cc1c545b2bd859715052d364b9ad161738969302bd5e1a5b7f7b0dc73d96a35ae8c72ce39839a8b656b0b3e2a0a40d2e6c2cebbcabca31aedc35d5351c3307d5d60a76561c94b4a1858c856923ce4f5cad1b8e7b2c4bdbdd2b6a4f8d97836a6b053b2b0e4aaa5dfa0fd4e282c6e270cc623568cc6361edfac0a9f172506dad6067c54149dbad25b8a0b1381cb3580d1af3585875bb9d836a6b053b2b0e4a2ab890b13c1d6af9e1553466b10e38eeb13c6d7b7e2efe53e3e5a0da5ac1ce8ae364c256007001a30ba7c62c5685c63c3ad0eeb2796abc1c545b2bd859719c4c985b7dfaa60fd0dcc5b16e38eeb1bc3bf0743b07d5d60a76561c2713decaf300baa602ed5bb14e8d5b8c4f63eb3b0570dc6379741eda41b5b5829d15c7c984820b177dd011ce990f6f8971696cf370b2fe3d35660eaaad15ecac388e27d327f80db5b450d189ea769f185f0a74ff54239f7a16bb836a6b053b2b8ee3c972feb97f741e2cd641639bc72b744e63f4beda2763e6a0da5ac1ce8ae3783225f793d270c1a20fb7bef8f22bb54f8d5bac43be7fd0bf933b480eaaad15ecac388e27d304c92f3a744e63f4addaa7c62dd64163eb1f63c0718f3eb40fd12763e6a0da5ac1ce8a6397e8d1c387cfa9c5858a7e6882fca0f6c9b8c57a686c7f528be31e5d7932660eaaad15ecac38768954a0fd2d195a98e88cc62adf265c198d699e64378e27e3e6a0da5ac1ce8a6397e84e1e163e8cdc6ab73e2ad07e4a218e77f445dbdf9b6a8fc6cd41b5b5829d15c72e910af4274e1efd6bb7633d19bb185feea01ac7ad2fbefcdf6a8fc6cd41b5b5829d15c72e513bf98d0b147dd158e597bd5726dbdf38345677d41e8d9b836a6b053b2b8e5d2225fdab93c7309e8c5dac028d717448b5f2c9857a07d5d60a76561c4e920b84e3d1983df58da618d7835f7f795d2d8e73f449dbdff36a8f6a28d5d60a76561c4ea264f98af760da978a4e6dec319e5ca01f8f3e54ffa4f6a886526dad6067c5e124eda2132e48f4e9f861568c2de79fc7d38e7a8e6a28d5d60a76561c4ed2f6c67041a26ba736f6188b8e5eafa9a5b18d8ea966bea7f6a886526dad6067c5e124fa04f7d7877141a25ffa147f57eda98d3ec6a10d3d3fd03c20d5ccbfa83daaa1545b2bd8597138493b5cc605897e69dcfcec94531b7d8c4363981fc81890c6ed1bb54735946a6b053b2b0e27399e38c692bb39c6a5b1cbb707c7765443a9b656b0b3e27092134963203a44fe4ced531b7e8c4163f7a95a1cd718c2510da5da5ac1ce8a439fe2f91db4f1610188eed158c620543b5f9ebc403fc8330086a731bca9960a40744a63e607eee078c6183c867314e84c94c1e562e1787271707caa9d6f4c5ea0ef3cfe8d2d5c801887264b1e413a88ec14ad836ae73fa440c75eb447f6bd5a2c08d197ec3daf836be71c053acf015889b667864521faa031ca63155642b5f383c90bb43ecdbfa6e4312c2c0cd10d1ab31890776ee728d03e34c60588f168d23cf5b3f0d10f8d8def59c7718bf1a876fecb1c05fa474a1ee37af4f80748b148c432f27d83f5f1b584c90b34258eb169e2f8e157a78a442cc71bb35a1caf1893c6f4a714e8b894078fbf8074aa50c4fc3416fe22118e538c2d053a2ead1d569f2a18311f8d417ead68c5262dd09a3c799ad68ae910ccbfd4818523e6d1c600c727c63775817e8192c67ab4fbdcb178c4b4b4eef34b452b973de8b8b207edf7d3623eed4b43381eb11e93166807258df56905e3542189c36be7fe711c625d262dd09a48be5f1613c7fa68bcafabc5a2128791a3d26d99b4403b2869acd3ad3c9674522acecfe7a2e0b64c5aa035a1fc7b769838d62977764c43dbd2735ab7f975fc8d99b4403b2869ac5b8af4e1a5386f933e985fa2da5ac1ce4a0af476b9486b723dabd7a78a4d5c8cd665bec6bd51aea1545b2bd8594981de3615967b2ad2bea875aae8c4f9b4ee5ed33afc41af71fdc6fa690e5ca3da5ac1ce4a0a74d8835f7f7943eda90214351767b5b83e633b5c43a9b656b0b392021d3b29d2fbd3bacaafa2c4117d50ff916a6b053b2b29d0715cfb6af2a98214bfd33afa442daebfd81e15e8e7a9b656b0b392021d27b5f3d2790ade093ea591f3cd7192e645ce41c7fcb4a7785beda942b5450ff23ce728b886526dad606725053acea23dc6efb587f0b25e9f2a5a5be02309af03bdc6f513317981d604fc991247ec6c6d6f5a85f9a59c6b8ef3f8c37b8e029df36ab1171deabfab168bda5ae83dbead16df7fc471aa9d77e628d0f98a6aec4df3e55e2b6258e046a5f7f496de5bbe11187bd37cf9e7c90b74bbb50a1720a2a2c9f9c31a0ab5dec33bfed0d16b7c9f1115cd9bff334781fe889247ec4b73e8b347033d6bda173e738e39ae4a73e8c3390ab47fb30e1720e222b447f1a3e6d3a77a8d857149ad287fac65cc5d1971109a4fefcf51a0dfa7e41157a142f893e6d6673e85a0bfb1684e4d45f9352dc36d2d8b7fa8009733e2b234b7fec71c05fa1f2879c42179cf55c5fa4d15cd17bd37ab3e2caa97a57ff3bafefd9bed9c72ee4c8ac9793e4f5ea095c40fc9c10588988a8ae88f2edaf29d76123ef264b7b38ab7fedb0bfadfbc2defb43d63fffffdefe45efe989de6e15b9317684dfa6b943c22226aaa9daf4c5ea095c870012222a2745443a9b656b0b3e2709213492322e27c4735946a6b053b2b0e27b9959f8a8f88d89b6aa6bf817d5443a9b656b0b3e2701225fbbfc7934744444d35f39fd51ed550aaad15ecac389ce4ceddfbfff378f28888a83d683f11e7a0da5ac1ce8ac34994ec4fc793474444edd1c387cfab3daaa1545b2bd8597138490a7444c4fe54a09f537b5443a9b656b0b3e27092dc0b1d11b1bfb90bf41f6e7df1e58fc7172022224e6bb5f2a8763aa8b656b0b3e2d8256ab78de0024544c463aa95ffa276f6027dc7c92322a276e7f11340e72dd00ff25b6c1111e7dadd62670eaaad15ecac3876891a5ca0888878ecd1c3872faa4d818e88e8cdee0e0e73506dad6067c5b14b64b9932322a2a61af9b5da2735d341b5b5829d15c7f164771eff9e1c2e5844c4d6a946bea776b102fdb15a5cb08888ad7bf0eb2fafab5da6402bf94db5b8601157e1d3677257be936f7ca8a81d820f7ccb921f35e06fb3ca33f2479fe393271762cc7fcbf5d6bee4bb8ecc3b15e29fbff2bfbd736f9737e29034f76ea87d322f1d545b2bd859711c4fd6e08245ec43c5f1e8b706553cdfd2647e5e5c749fd17fa3b936292f83bc6e5aa6efd487cb1c71014fcd3107d5d60a76561c271366ef23f6e542acbdd7a31f7c3db967d1332deb752df77b5e76bd87fc0278ec4573e52f6a9f9a4b0eaaad15ecac384e26f421a35a5cc0d8364dd01f353f3e51817b457f9f9a3ba36a7bf92fb782fdbdfaf0fdc7b6794744ed5373c741b5b5829d15c7c9845a887ca3308ea858fde482dce6c4a9b9b2562ad63e0ffe42f6b0e338cd8997d43e35571c545b2bd859719c4cd816021730d64f05e9af6bdc4bbe0aaf0bad938f7d04a1bf71bdc5269c9a1b0eaaad15ecac3828690ef3b6c5e3ad02f4a10ad175fd8d73227ee775a575968b8e1ba2f1f60f6b9f9a0b0eaaad15ecac3828a927a05a5cd0588fb6a77ceab02df6e375e73d6bbdc6f51beba171fe48eda939e0a0da5ac1ce8a83926ae2bda6161734c6e6bde507bffef2965ee3d8c7e5789d66af7ad570dc1d545b2bd8597150d286163206a53d80cf720a637a6daffab65ee338c4b070bc1d545b2bd859715052cb245b078fa38a462ef82d20dbd03ab471c43176506dad6067c541494d876cefa8c5058ebee950fbe84e0cbdc6b18d79695bbaa931c91d20833aeb365307d5d60a76561c94f4185ce0e893af346b329dba993efa909d9e61e1789a836a6b053b2b0e4abae30b4a6a6981a333da63c6abccd11f8d551eeb3b8876e117c7d11c545b2bd8597150d29d7ce2f72fa732c6d5ce6de2b8461fce3b2275506dad6067c5414977da557f5cf058964f67e4e2dff83486afe648b55f1a9f6b6a71eccc41b5b5829d1507253dce85402d2e7ccccfe391f3cceba3317d3bdb5a5fda78e078ed38a8b656b0b3e2a0a4c7b5739bf806625e39cfbc7e1ae37c33b1131a0b7fa31ac769c741b5b5829d15072505f806621efa243ff34245ac8b4f2d666f7a791a8797d5e218ed38a8b656b0b3e2a0a42769b27cab16df444c4b9fe2b908b8516dec715ec4b4f639bd610eaaad15ecac3828e9493e3fa616df484cc313449fe07e260a8e496c83e6c08dec4dcf4f35ef0db53826c739a8b656b0b3e2a0a4057c237178d96b8e93726e7a5efa607c4e2d8ec5710eaaad15ecac382829c9698e79b4a3151c83d8b61cc9ce63dfd31be6a0da5ac1ce8a8392127da2f89e5b7c4371759a14be1716d77dc48eb643df379d1f769ed04576921c545b2bd8597150d24af6a2a7a1c3d7dc3e1717920b88d3b8e88e92836a6b053b2b0e4a5ad1a4c82fad1c584e69c465e594c7e1b573fdb8be89836a6b053b2b0e4a5ad1e155befa7d40dac0f28dc0b8129ff2508bf32b2e05d773c541b5b5829d1507253d8b0e01f2b33e57a475e85be8f25b807110392f7d185a873fa8c5755c71506dad6067c54149cfd2f6faf00dc6f93409bed506b5d72d3c1117919da7ab516df3d33b71dd561c545b2bd8597150d23de01b8cb35df4fc56c445b53986f32f6aed0804d7e9591c545b2bd8597150d2f36812e4014a17d4d619aecf8843d25ccbc5fc0bd2def34db5b83ecfe2a0da5ac1ce8a83929e4787e87e462abed1382dc539e696227d61b81ecfe3a0da5ac1ce8a8392ee237bd1fb691b0aaec3882969ee7da016e765fc4eebe99fd4e23a3c8f836a6b053b2b0e4aba8f76a10bdf703cd63ec470fd45cc4173f07db5383fe331df05a316d7df791c545b2bd8597150d27dddfae2cbafd4e29bdebaec39472f52a46b5a379fa9c5f5b60f07d5d60a76561c94745f0f7efde54f6af18d6f99063d776b445752a4d955f69ecd41b5b5829d150725bd08ed457fad16dffc16a53847af3437734efa18d5ae0b7f31e52407d5d60a76561c94f422b417fd5fd5e20ad81a6d00798e73744d733417f71bed3d5ff907311c545b2bd8597150d28bd227d11db5b812b642eb20bf1b1843c851efd1f67a90c7fb3aa8b656b0b3e2a0a417b5f573d11eec76570bae9f88de68ce6efa67b42ef3b56ee2a0da5ac1ce8a83925e86067cb3cf8a5671f6177770bd44f44873f6865a9ccf6ba75a75a9af751307d5d60a76561c94f432f489e41f59c415b266ed7de33a89e8593b078bf37acdf4beaf74e7c6710eaaad15ecac3828e965e993e91bb5b852d648c539cf738ea1690e6feaa1ffaa5107bd56e4a0da5ac1ce8a83925ed696f6a2efe48b28b112edd6509ce76b73c8bd6773506dad6067c54149afa27d42e1ca590bbdc7bd7ff53762046d4ee37c5f0b7d105dfa991b1507d5d60a76561c94f42af409e55f0ac115b422f8de2346a5ed760b3f6787effd2a1c545b2bd8597150d2ab5af321d3835f7f794b2dbeef8891696efbd6339cf7a3534dfa5c2dbeefab70506dad6067c54149af4a9fc6cfa8c51535b2f6c183ef39620d56bc7385eff7aa1c545b2bd8597150d243d0a7f1aabebc92f3ceb1156b3b1fad5af4ae5a7caf57e5a0da5ac1ce8a83921e8a067a355f29d551c12b6af17d46acc99aae23a9061de42bdd1507d5d60a76561c94f450d6b217adc3be3c783f36652da73af46173d0dbea4e72506dad6067c541490f69f481cea98dd82acdfda11fdfa0daf3a95a7c6f87e2a0da5ac1ce8a83921e923ec15e548b2b700439b5115bb582531df8be0ec941b5b5829d1507253db407837e9d549fc0f9b6606c5a3bbd87db47cf547366b91dd641b5b5829d1507259d820e9786fa86613bbcc3f712b125a39dea9873db75506dad6067c5414927842bb447fa047e5d2dbd87884dd1b6e08782e176d2a3478fbf1589efe5d01c545b2bd8597150d2a968a087f8a652dbdbc7f710b145a31c01abc6ccfaf85f07d5d60a76561c94744a231c2eb58b23b8fc115bd4f64a717be9c59ca736761c545b2bd8597150d229f53ed0eda2082e7bc496f57ecbac6acbcb6a71d9a7e2a0da5ac1ce8a83924e4d8721ddded5a141cecf5745d470bb595a3b4f4ecb3b2907d5d60a76561c94740e3d9ed3d21ec2276a717923e2682ffab65adc7e96b2e4352307d5d60a76561c947446b8c29792bde788bde0f6b3146db78b7d99cc41b5b5829d1507259d8b56ec7f508b2b7d6eedfc1a2e6744fcaea773d14b9ddad871506dad6067c54149e7a4c1fe402daefc99e1f24504a26d6856ad76d0b2cdc641b5b5829d1507259ddbad857f0d5c039d73cf1117b0f4771a96b8a58e38a8b656b0b3e2a0a4737bb4fc039570b922e24cb42dcd859667760eaaad15ecac3828e912dab9241a884969ef39f73d475cc252e7a2dbb52b5ca6b939a8b656b0b3e2a0a44b59e27c74db7bc7e5898873e1763595f6a140cbb10807d5d60a76561c947449b7bef8f22f6a71700e2de79e23ae46db901f8a8fdbd7a1f572def93807d5d60a76561c947469735d34d4de73ee7b8eb8026d43cfabc5edeb905413bafc652307d5d60a76561c9474691a747fa71e07ea5034e03fabc5fc11b13f6d4b3fa9c5edec505413667b84e84538a8b656b0b3e2a0a43d98e3a2616fe7b32246a36dc8bf3a84dbd7a1a816ccfa08d18b70506dad6067c541497ba181f143f371d00e25453ae272e63815a9edf37db598bf070eaaad15ecac3828694f344093dfd9d1ebf9ad885ecd549cbbbf05d641b5b5829d150725ed8d26c3576a71100f25453ae27c8f1e3efcc31cc55939babb638338a8b656b0b3e2a0a43d9a69527caf16f3476c9d8af373d90e9fe6a0da5ac1ce8a8392f64a0337cb33a43511bbf9a652440fb44dbca016b7974353ae617e72ce41b5b5829d150725ed9506cecf7dc5413db407bffef2965a5c8e882d99e362fd4edbc671397ae4a0da5ac1ce8a83920e0007f7d052a463eb662eceafaac5e5e895836a6b053b2b0e4ada3b0de4dfabc5413eb4769f272e47c49ab5bb2870bb38346dd3afa9c5e5e899836a6b053b2b0e4a3a82398bf4ad41ae28471c82b6ad7f3fc7c5c01deda5fb47a471597ae7a0da5ac1ce8a83928e421369b69fccf29565e51beafc58c445a958bea9b9ee5b4e713b38b4d14f233aa8b656b0b3e2a0a423d100cffacb0ea34fa8884adb93c5793f85356c4b0eaaad15ecac3828e968e62ed2237cc329e22234a76fabc5f93e85b5ece838a8b656b0b3e2a0a423d280df548b93610abe27fb51a74fd88ad897e6f0ab739ed2b0b6a78ecb331a07d5d60a76561c947454739e93de59d3648b6dd15ef3ec3f59b5963de71d07d5d60a76561c9474642ad2b3ddddb1e3bd69b5b83c11bdf1c5eeb9f79a6d6dc5d91c545b2bd8597150d295c04932a5b6074fcb12d10515c959afd7ecf843412d2ed3c81c545b2bd8597150d23558624fdada61232e53c452b43dbc30f785c01de55eedb51a07d5d60a76561c94744d7428e72763e1c49952f6a6a317ed3a09ced329b50be9abfed57c07d5d60a76561c94746d3451fc4d409c4453cab9e958928ae38d25ce359bf2fa9b88b85c6be2a0da5ac1ce8a8392ae51bb771927d3d4b407e35b0071b922a6d0e61ccec7a9695bdbccf36b1c545b2bd8597150d2b5d2a49dfc87682bde93d11ecd704feb8ab1688ebda6b9b6c8693d5371eefa37040fcd41b5b5829d1507255d331569dfea83936b0e9ac09f6823ca175ce2e05498efa9c5793787b60384cbb6560eaaad15ecac3828e9daa940fa3ed0597e9da5b2a5c3c098963ff4d5e23c9b83b7256f537a8dcbb7660eaaad15ecac3828e95668627dad1627dd1cbcc7d3f6e871f922cea2b9f3aee6d07dbdc6f93507e5dff4a3781d545b2bd8597150d22dd1dec762170f7734c9bfd7c6f6865ee332461cd70af38f7a8df3692eda767c5f352ee35638a8b656b0b3e2a0a45bd3f6627112ce491bdd5d2dcbe6cee3c57eda05c045f79877b42cb9cf5f1c545b2bd8597150d22df2853b4dfed97e45e22c5a8eefb2471d3bad302f7a0170c773532d2ee71639a8b656b0b3e2a0a45bd62edee1e49c9b3686ec516f582fa73276dae9405cd6ad72506dad6067c54149b7ae5d91c649ba046da4df6a996ee8352e6fac8b0af3cd9e0ab3e5888e39a8b656b0b3e2a0a4f1580f17108ff31eb5f7f055acafe96f5ce61897c6f6338df14f7a8de3bf84b67390fbf60b0eaaad15ecac382869fc4e7b0e8b3c68e63c2ed45ab6d7f51a973bc6a0e2f7aac6f253bdc6715e92e6971f4d8acb1d8f39a8b656b0b3e2a0a4719af62416fd624b45cb75742fb536f497f5372e7bf44763f6678d5d57a731763cd7734a6d3f0eaaad15ecac382869b05ef7a677b4617d9fc3d17e796f5963f4835ee3f8f540733c17a52fc041b5b5829d1507258db369235be4118e17a1c3e6dbd90b5a9ec6e0358dc5e77a8de3d48bb6d79ca3b00b72506dad6067c54149e37cedfc1c4ef6deb840a458cf47ebfabad6f9677a8de3d19b766488ef25cee6a0da5ac1ce8a8392c67eb421bee23d55bdc689df1bed25fde8c2a10df25dfd8def292e47ebd4b7c6dd979ff537aeffdeb4b98bef27f6e3a0da5ac1ce8a8392c6c5f8d07084d31e276903fd54fcf8d33ca7fa825490df7281f33ad4dfb87e7be5b9ea9d0bbdc6f716fb73506dad6067c54149e372bcd1aac58d6204da707ff0e1ae36de9c0e3941ebe48f1e5fada32eefbcd897de438e9e0ec841b5b5829d1507258dab69878eb8818cc285c87b5a7a2f1fa938bda43e17a9e7dd6e81deabcf237fe20f2df9abfa703d8d42efc5e7c4f1bdc6e539a8b656b0b3e2a0a47175de0b5d43a13ec9c5ca85cb7b937a8fc35ff5d77b7855efe5a6ded3e77a6fc39c3fde570af3b41c545b2bd8597150d2381cef8969c3eff24b2e87a4f7784fc5e023176e79dbf4de5f94e7f4df71ddcc41f95f6acbf1a296e91d7fb86859bb7864e794fc3ef59e739e79620eaaad15ecac3828691c9e0b960ac3623fe6b914bde77f939fe55fe527f11ef867a67572d35448aebb989c5750f4dfff28cfc8f35e9f3bfab78e2ed6e9dff66999bfcaff13e7fc37fdff70b9d64aefd95f56ca35849938a8b656b0b3e2a0a4311d6f3cda8856bf471df37261f687955ee3bc8b6938a8b656b0b3e2a0a4313d6f4cdea8f41a37b8887db43de69cca5888836a6b053b2b0e4a1af3d1c6f5820ecf3fd66bdc002388e68cbf1d9afbd717e6a0da5ac1ce8a8392c6fcb4b1bde8f3b27a8d1b6484698efc2fb53887627e0eaaad15ecac3828692c4785daf7df0ef7edb498ceadc75f20cab3993be4a0da5ac1ce8a8392461f729e7adbf441fd8f9a0337f51ae7472ccf41b5b5829d1507258dbe68affa9a36d68f55ac577fffeed6698cfd40ab4ff41ae742f4c541b5b5829d1507258d7ea9580ff960a6389b8f94729bdc781c545b2bd8597150d218433b05724faf71a38fbeb9286b6fd9cf3ac9174b06e5a0da5ac1ce8a8392c678b4a1dfd6069f53209dd318fde053182aca2fe86f1ccb1887836a6b053b2b0e4a1a63f385251582e19fc0b6162eca1a93fcb0ef0a39a8b656b0b3e2a0a4b11e2ed6da63cbfdd533f35eb2d67d7e8075e51c545b2bd8597150d258279febf4394f9ffbd4df5858e272b44eef792f59af71ddc73a39a8b656b0b3e2a0a4b17e3edc764151c1f6ed7bb9d078415a67dfb5d3163997bc610eaaad15ecac3828696c938acd2b2a3a478fef5401ca39ec46ebe27e3b65f186d6d175f5e1fa8bed71506dad6067c54149238ef39ea28ad4b7de6b74b1521f16b2d1e9bdf979d5fee181db7acf6faa183f6bfa6fb85e221c545b2bd8597150d288b3a868fd3b15b0ff24ff51c5ec3d176ff563d1eb9196d70ff5ff4ecbfe81decbf3f29c5cd37fc3f71b5171506dad6067c5414923ae42c5ee1915efffa202f8be8be0311faa307e2307ff21d65674bd97ff4dcbe5dcef6939feb397c58558ff3b5cde88cb72506dad60672591e83d54585f6eedb5d6fa27afec59ff9d482c1d545b2bd8191111cbc3ce8888581e764644c4f2b033222296879d1111b13cec8c8888e5616744442c0f3b23226279d8191111cbc3ce8888581e764644c4d27efbbbff0f48a9cd4888434f1b0000000049454e44ae426082);

-- --------------------------------------------------------

--
-- Table structure for table `approve_student`
--

CREATE TABLE `approve_student` (
  `Name` varchar(15) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Phone_Number` int(15) NOT NULL,
  `TRANSACTION_ID` varchar(15) NOT NULL,
  `Payment_Method` varchar(15) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Taka` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `approve_student`
--

INSERT INTO `approve_student` (`Name`, `Email`, `Phone_Number`, `TRANSACTION_ID`, `Payment_Method`, `Password`, `Taka`) VALUES
('Shahriar Shezan', 'shahriarshezan@gmail.com', 1788759084, '017S*', 'Rocket', 'shezan', 2500),
('Suraiya Rahman', 'suraiyarahman@gmail.com', 1757761932, '017R*', 'Nogod', 'suraiya', 1800),
('Jubayer Ahmed', 'jubayerahmed@gmail.com', 1742883482, '017J*', 'Rocket', 'jubayer', 1900),
('Fahim Hossain', 'fahimhc266@gmail.com', 1648236450, '016F*', 'Bkash', 'fahim', 1200),
('Israt Jahan Eva', 'jucse28.348@gmail.com', 1832264884, '018E*', 'Nogod', 'isratjahan', 2500),
('Al Emam', '19202103242@cse.bubt.edu.bd', 1876543218, '018E*', 'Rocket', 'alemam', 2500),
('Tunazzinur Rahm', '19202103268@cse.bubt.edu.bd', 1876543218, '018T*', 'Nogod', 'tunazzinur', 1900);

-- --------------------------------------------------------

--
-- Table structure for table `course_details`
--

CREATE TABLE `course_details` (
  `Subject_Name` varchar(120) NOT NULL,
  `Subject_Code` varchar(50) NOT NULL,
  `Teacher_Name` varchar(50) NOT NULL,
  `Teacher_ID` varchar(50) NOT NULL,
  `Video_Link` varchar(500) NOT NULL,
  `Class` varchar(255) NOT NULL,
  `Teacher_Email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `course_details`
--

INSERT INTO `course_details` (`Subject_Name`, `Subject_Code`, `Teacher_Name`, `Teacher_ID`, `Video_Link`, `Class`, `Teacher_Email`) VALUES
('Physics', 'Phy-101', 'Shovon Roy', '8', 'https://www.youtube.com/watch?v=OEMkw_uuiU0', '12', 'shovonroy@gmail.com'),
('Physics', 'Phy-101', 'Sanzida Akter', '11', 'https://www.youtube.com/watch?v=kX8lYD9_PsA', '12', 'sanzidaaktersuraiya@gmail.com'),
('ICT', 'ICT-224', 'Tonima Islam', '10', 'https://www.youtube.com/watch?v=VLflTjd3lWA', '11', 'tonimaislam214@gmail.com'),
('Biology', 'Bio-321', 'Rafiqul Jakir', '9', 'https://www.youtube.com/watch?v=VLbZ8Vm5KP4', '11', 'rafiquljakir@gmail.com'),
('Chemistry', 'Che-101', 'Rafiqul Jakir', '9', 'https://www.youtube.com/watch?v=NIwcDnFjj98', '12', 'rafiquljakir@gmail.com'),
('Physics', 'Phy-101', 'Tonima Islam', '10', 'https://www.youtube.com/watch?v=JImwNbK2FmQ', '11', 'tonimaislam214@gmail.com'),
('Physics', 'Phy-101', 'Tonima Islam', '10', 'https://www.youtube.com/watch?v=-RfdFKa2Jgc', '12', 'tonimaislam214@gmail.com'),
('Physics', 'Phy-101', 'Tonima Islam', '10', 'https://www.youtube.com/watch?v=3HyORmBip-w', '11', 'tonimaislam214@gmail.com'),
('Chemistry', 'Che-101', 'Tonima Islam', '10', 'https://www.youtube.com/watch?v=hguIXid-NL8', '11', 'tonimaislam214@gmail.com'),
('ICT', 'ICT-224', 'Rafiqul Jakir', '9', 'https://www.youtube.com/watch?v=L-fbxGjFI8Q', '12', 'rafiquljakir@gmail.com'),
('Biology', 'Bio-321', 'Rafiqul Jakir', '9', 'https://www.youtube.com/watch?v=Q6mSOwLoqvE', '11', 'rafiquljakir@gmail.com'),
('Biology ', 'Bio-321', 'Rafiqul Jakir', '9', 'https://www.youtube.com/watch?v=ATwMKgaEYEo', '11', 'rafiquljakir@gmail.com'),
('Chemistry', 'Che-101', 'Rafiqul Jakir', '9', 'https://www.youtube.com/watch?v=6qBHmxW4Xpc', '11', 'rafiquljakir@gmail.com'),
('Chemistry', 'Che-101', 'Rafiqul Jakir', '9', 'https://www.youtube.com/watch?v=MGAYUjmZYlM', '12', 'rafiquljakir@gmail.com'),
('ICT', 'ICT-224', 'Sanzida Akter ', '11', 'https://www.youtube.com/watch?v=cgmly6zvZbs', '12', 'Sanzidaaktersuraiya@gmail.com'),
('Physics', 'Phy-101', 'Sanzida Akter ', '11', 'https://www.youtube.com/watch?v=4fElkmhxgvU', '12', 'Sanzidaaktersuraiya@gmail.com'),
('ICT', 'ICT-224', 'Sanzida Akter', '11', 'https://www.youtube.com/watch?v=CPAOaLkmp6c', '11', 'Sanzidaaktersuraiya@gmail.com'),
('Physics', 'Phy-101', 'Shovon Roy', '8', 'https://www.youtube.com/watch?v=3It49x562b0', '12', 'shovonroy@gmail.com'),
('Physics', 'Phy-101', 'Shovon Roy', '8', 'https://www.youtube.com/watch?v=OMAXYCmLfEs', '12', 'shovonroy@gmail.com'),
('Physics', 'Phy-101', 'Shovon Roy', '8', ' Semiconductor Electronics: https://www.youtube.com/watch?v=hccEUqoviH8', '12', 'shovonroy@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `new_anrolled_coures`
--

CREATE TABLE `new_anrolled_coures` (
  `Subject_Name` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Phone_Number` varchar(50) NOT NULL,
  `Payment_method` varchar(50) NOT NULL,
  `Transaction_ID` varchar(50) NOT NULL,
  `TK` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `new_anrolled_coures`
--

INSERT INTO `new_anrolled_coures` (`Subject_Name`, `Email`, `Phone_Number`, `Payment_method`, `Transaction_ID`, `TK`) VALUES
('ICT', 'rafiquljakir@gmail.com', '01879074212', 'Bkash', 'sd45sd51', '500'),
('ICT', 'tonimaislam214@gmail.com', '01319305402', 'Bkash', 's5d71vf', '500'),
('Physics', 'tonimaislam214@gmail.com', '01319305402', 'Bkash', 's5d71vf', '700'),
('Chemistry', 'tonimaislam214@gmail.com', '01319305402', 'Bkash', 's5d71vf', '700'),
('Biology', 'tonimaislam214@gmail.com', '01319305402', 'Bkash', 's5d71vf', '600'),
('ICT', 'jannatulmim761@gmail.com', '0187952225', 'Bkash', 'df2515', '500'),
('Physics', 'jannatulmim761@gmail.com', '0187952225', 'Bkash', 'df2515', '700'),
('Chemistry', 'jannatulmim761@gmail.com', '0187952225', 'Bkash', 'df2515', '700'),
('Biology', 'jannatulmim761@gmail.com', '0187952225', 'Bkash', 'df2515', '600'),
('Chemistry', 'rafiquljakir@gmail.com', '01879074255', 'Bkash', 's8d2', '700'),
('Biology', 'rafiquljakir@gmail.com', '01879074255', 'Bkash', 's8d2', '600');

-- --------------------------------------------------------

--
-- Table structure for table `payment_details`
--

CREATE TABLE `payment_details` (
  `Email` varchar(50) NOT NULL,
  `Phone_Number` varchar(15) NOT NULL,
  `TRANSACTION_ID` varchar(15) NOT NULL,
  `Payment_Method` varchar(50) NOT NULL,
  `Taka` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `payment_details`
--

INSERT INTO `payment_details` (`Email`, `Phone_Number`, `TRANSACTION_ID`, `Payment_Method`, `Taka`) VALUES
('tonimaislam214@gmail.com', '01319305402', '123T*', 'Bkash', 2500),
('rafiquljakir@gmail.com', '01627658437', '016R*', 'Nogod', 2500),
('sanzidaaktersuraiya@gmail.com', '01557236032', '015S*', 'Rocket', 2500),
('jannatulmim761@gmail.com', '01893259202', '018J*', 'Bkash', 2500),
('srrifat781@gmail.com', '01608130767', '016S*', 'Nogod', 1900),
('shahinur02042017@gmail.com', '01858755116', '018S*', 'Rocket', 2000),
('walidmunsi@gmail.com', '01580582406', '015W*', 'Bkash', 2500),
('19202103247@cse.bubt.edu.bd', '01794059375', '017M*', 'Rocket', 1100),
('19202103269@cse.bubt.edu.bd', '01745677027', '017H*', 'Nogod', 1300),
('19202103248@cse.bubt.edu.bd', '01722204245', '017I*', 'Rocket', 2500),
('nisattamima44cse@gmail.com', '01822471856', '018T*', 'Bkash', 2000),
('19202103245@cse.bubt.edu.bd', '01319305402', '013N*', 'Nogod', 2500),
('aurpadatta@gmail.com', '01742154323', '017A*', 'Bkash', 2500),
('shahriarshezan@gmail.com', '01788759084', '017S*', 'Rocket', 2500),
('suraiyarahman@gmail.com', '01757761932', '017R*', 'Nogod', 1800),
('jubayerahmed@gmail.com', '01742883482', '017J*', 'Rocket', 1900),
('fahimhc266@gmail.com', '01648236450', '016F*', 'Bkash', 1200),
('jucse28.348@gmail.com', '01832264884', '018E*', 'Nogod', 2500),
('19202103242@cse.bubt.edu.bd', '01876543218', '018E*', 'Rocket', 2500),
('19202103268@cse.bubt.edu.bd', '01876543218', '018T*', 'Nogod', 1900),
('sanzidaaktersuraiya@gmail.com', '01557236032', '015S*', 'Bkash', 1400);

-- --------------------------------------------------------

--
-- Table structure for table `post`
--

CREATE TABLE `post` (
  `Title` varchar(15) NOT NULL,
  `Date` varchar(50) NOT NULL,
  `Description` varchar(500) NOT NULL,
  `Role_As` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `post`
--

INSERT INTO `post` (`Title`, `Date`, `Description`, `Role_As`) VALUES
('Velocity & Wave', '19-03-2022', 'Velocity is the rate of motion, speed or action. An example of velocity is a car driving at 75 miles per hour.', 'Teacher'),
('Human Organs', '01-03-2022', 'The solid organs are the liver, pancreas, spleen, kidneys, and adrenal glands. The hollow organs of the abdomen are the stomach, intestines, gallbladder, bladder, and rectum. In the thoracic cavity the heart is a hollow, muscular organ.', 'Teacher'),
('Astronomy', '22-02-2022', 'Astronomy is a natural science that studies celestial objects and phenomena. It uses mathematics, physics, and chemistry in order to explain their origin and evolution. Objects of interest include planets, moons, stars, nebulae, galaxies, and comets.', 'Teacher'),
('Announcement', '14-02-2022', 'I can\'t take any class today. I\'m sick . (-_-)', 'Teacher'),
('Binary to Decim', '03-03-2022', 'To convert a binary integer to decimal, start by adding the left-most digit to 0. Step 2. Next, multiply this by 2, and add the next digit in your number (as you progress from left to right) to this product. (In other words, multiply the current product in each step by 2 and add the current digit).', 'Teacher'),
('Organic compoun', '28-02-2022', 'Organic compound, any of a large class of chemical compounds in which one or more atoms of carbon are covalently linked to atoms of other elements, most commonly hydrogen, oxygen, or nitrogen. The few carbon-containing compounds not classified as organic include carbides, carbonates, and cyanides.', 'Teacher'),
('When measuring ', '18-03-2022', 'Absorbance measurements were made on liquid samples containing organic material. Some negative absorbance values were recorded, could these be due to fluorescence of the sample?', 'Student'),
('Problem', '2-3-2022', 'What do you mean by “survival of the fittest”?       ', 'Student'),
('Announcement', '10-02-2022', 'We will be adding more interesting subjects to our Learner\'s Point from 15-06-2022', 'Admin'),
('Good to Know ', '21-02-2022', 'What is the significance of 21st February?\r\n \r\n21 February was declared to be the International Mother Language Day by UNESCO in 1999. It has been observed throughout the world since 21 February 2000. The declaration came up in tribute to the Language Movement done by the Bangladeshis (then the East Pakistanis).', 'Admin'),
('Velocity and Sp', '10-02-2022', 'Speed is the time rate at which an object is moving along a path, while velocity is the rate and direction of an object’s movement. Put another way, speed is a scalar value, while velocity is a vector.', 'Teacher'),
('Electric Charge', '05-01-2022', 'Electric Charge Charge is the property associated with matter due to which it produces and experiences electric and magnetic effect.', 'Teacher'),
(' Magnetism and ', '27-02-2022', 'All matter exhibits magnetic properties when placed in an external magnetic field. Even substances like copper and aluminum that are not normally thought of as having magnetic properties are affected by the presence of a magnetic field such as that produced by either pole of a bar magnet.', 'Teacher'),
('Hydrogen', '04-02-2022', 'Hydrogen bonding, interaction involving a hydrogen atom located between a pair of other atoms having a high affinity for electrons; such a bond is weaker than an ionic bond or covalent bond but stronger than van der Waals forces.', 'Teacher'),
('Algorithm', '30-02-2022', 'An algorithm is a set of instructions for solving a problem or accomplishing a task. One common example of an algorithm is a recipe, which consists of specific instructions for preparing a dish or meal.', 'Teacher'),
('Plant Kingdom', '26-03-2022', 'The plant kingdom has been classified into five subgroups according to the above-mentioned criteria:\r\nThallophyta.\r\nBryophyta.\r\nPteridophyta.\r\nGymnosperms.\r\nAngiosperms.', 'Teacher');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `Student_ID` int(11) NOT NULL,
  `Name` varchar(15) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Phone` int(15) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `image` blob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`Student_ID`, `Name`, `Email`, `Phone`, `Password`, `image`) VALUES
(34, 'Tonima Islam', 'tonimaislam214@gmail.com', 1319305402, 'tonima', 0x53797374656d2e44726177696e672e4269746d6170),
(35, 'Rafiqul Jakir', 'rafiquljakir@gmail.com', 1627658437, 'rafiqul', 0x53797374656d2e44726177696e672e4269746d6170),
(36, 'Sanzida Akter', 'sanzidaaktersuraiya@gmail.com', 1557236032, 'sanzida', ''),
(37, 'Jannatul Mim', 'jannatulmim761@gmail.com', 1893259202, 'jannatul', 0x53797374656d2e44726177696e672e4269746d6170),
(38, 'Saydur Rahman', 'srrifat781@gmail.com', 1608130767, 'saydur', 0x53797374656d2e44726177696e672e4269746d6170),
(39, 'Shahinur Hossai', 'shahinur02042017@gmail.com', 1858755116, 'shahinur', ''),
(40, 'Walid Al Hasan', 'walidmunsi@gmail.com', 1580582406, 'walid', 0x53797374656d2e44726177696e672e4269746d6170),
(41, 'Mustafizur Rahm', '19202103247@cse.bubt.edu.bd', 1794059375, 'mustafizur', ''),
(42, 'HR Shammo', '19202103269@cse.bubt.edu.bd', 1745677027, 'shammo', 0x53797374656d2e44726177696e672e4269746d6170),
(43, 'Imran Nazir', '19202103248@cse.bubt.edu.bd', 1722204245, 'imran', ''),
(44, 'Tamima Nishat', 'nisattamima44cse@gmail.com', 1822471856, 'tamima', 0x53797374656d2e44726177696e672e4269746d6170),
(45, 'Nayma Khatun', '19202103245@cse.bubt.edu.bd', 1319305402, 'nayma', 0x53797374656d2e44726177696e672e4269746d6170),
(46, 'Aurpa Datta', 'aurpadatta@gmail.com', 1742154323, 'aurpa', 0x53797374656d2e44726177696e672e4269746d6170),
(47, 'Shahriar Shezan', 'shahriarshezan@gmail.com', 188759084, 'shezan', ''),
(48, 'Suraiya Rahman', 'suraiyarahman@gmail.com', 1757761932, 'suraiya', 0x53797374656d2e44726177696e672e4269746d6170),
(49, 'Jubayer Ahmed', 'jubayerahmed@gmail.com', 1742883482, 'jubayer', ''),
(50, 'Fahim Hossain', 'fahimhc266@gmail.com', 1648236450, 'fahim', 0x53797374656d2e44726177696e672e4269746d6170),
(51, 'Israt Jahan Eva', 'jucse28.348@gmail.com', 1832264884, 'isratjahan', 0x53797374656d2e44726177696e672e4269746d6170),
(52, 'Al Emam', '19202103242@cse.bubt.edu.bd', 1876543281, 'alemam', ''),
(53, 'Tunazzinur Rahm', '19202103268@cse.bubt.edu.bd', 1879765431, 'tunazzinur', 0x53797374656d2e44726177696e672e4269746d6170);

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `Subject_Name` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `subjects`
--

INSERT INTO `subjects` (`Subject_Name`, `Email`) VALUES
('ICT', 'tonimaislam214@gmail.com'),
('Physics', 'tonimaislam214@gmail.com'),
('Chemistry', 'tonimaislam214@gmail.com'),
('Biology', 'tonimaislam214@gmail.com'),
('ICT', 'rafiquljakir@gmail.com'),
('Physics', 'rafiquljakir@gmail.com'),
('Chemistry', 'rafiquljakir@gmail.com'),
('Biology', 'rafiquljakir@gmail.com'),
('ICT', 'sanzidaaktersuraiya@gmail.com'),
('Physics', 'sanzidaaktersuraiya@gmail.com'),
('Chemistry', 'sanzidaaktersuraiya@gmail.com'),
('Biology', 'sanzidaaktersuraiya@gmail.com'),
('ICT', 'jannatulmim761@gmail.com'),
('Physics', 'jannatulmim761@gmail.com'),
('Chemistry', 'jannatulmim761@gmail.com'),
('Biology', 'jannatulmim761@gmail.com'),
('ICT', 'srrifat781@gmail.com'),
('Physics', 'srrifat781@gmail.com'),
('Chemistry', 'srrifat781@gmail.com'),
('Physics', 'shahinur02042017@gmail.com'),
('Chemistry', 'shahinur02042017@gmail.com'),
('Biology', 'shahinur02042017@gmail.com'),
('ICT', 'walidmunsi@gmail.com'),
('Physics', 'walidmunsi@gmail.com'),
('Chemistry', 'walidmunsi@gmail.com'),
('Biology', 'walidmunsi@gmail.com'),
('ICT', '19202103247@cse.bubt.edu.bd'),
('Biology', '19202103247@cse.bubt.edu.bd'),
('Chemistry', '19202103269@cse.bubt.edu.bd'),
('Biology', '19202103269@cse.bubt.edu.bd'),
('ICT', '19202103248@cse.bubt.edu.bd'),
('Physics', '19202103248@cse.bubt.edu.bd'),
('Chemistry', '19202103248@cse.bubt.edu.bd'),
('Biology', '19202103248@cse.bubt.edu.bd'),
('Physics', 'nisattamima44cse@gmail.com'),
('Chemistry', 'nisattamima44cse@gmail.com'),
('Biology', 'nisattamima44cse@gmail.com'),
('ICT', '19202103245@cse.bubt.edu.bd'),
('Physics', '19202103245@cse.bubt.edu.bd'),
('Chemistry', '19202103245@cse.bubt.edu.bd'),
('Biology', '19202103245@cse.bubt.edu.bd'),
('ICT', 'aurpadatta@gmail.com'),
('Physics', 'aurpadatta@gmail.com'),
('Chemistry', 'aurpadatta@gmail.com'),
('Biology', 'aurpadatta@gmail.com'),
('ICT', 'shahriarshezan@gmail.com'),
('Physics', 'shahriarshezan@gmail.com'),
('Chemistry', 'shahriarshezan@gmail.com'),
('Biology', 'shahriarshezan@gmail.com'),
('ICT', 'suraiyarahman@gmail.com'),
('Chemistry', 'suraiyarahman@gmail.com'),
('Biology', 'suraiyarahman@gmail.com'),
('ICT', 'jubayerahmed@gmail.com'),
('Physics', 'jubayerahmed@gmail.com'),
('Chemistry', 'jubayerahmed@gmail.com'),
('ICT', 'fahimhc266@gmail.com'),
('Physics', 'fahimhc266@gmail.com'),
('ICT', 'jucse28.348@gmail.com'),
('Physics', 'jucse28.348@gmail.com'),
('Chemistry', 'jucse28.348@gmail.com'),
('Biology', 'jucse28.348@gmail.com'),
('ICT', '19202103242@cse.bubt.edu.bd'),
('Physics', '19202103242@cse.bubt.edu.bd'),
('Chemistry', '19202103242@cse.bubt.edu.bd'),
('Biology', '19202103242@cse.bubt.edu.bd'),
('ICT', '19202103268@cse.bubt.edu.bd'),
('Physics', '19202103268@cse.bubt.edu.bd'),
('Chemistry', '19202103268@cse.bubt.edu.bd'),
('Physics', 'sanzidaaktersuraiya@gmail.com'),
('Chemistry', 'sanzidaaktersuraiya@gmail.com'),
('Physics', 'rafiquljakir@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `teacher`
--

CREATE TABLE `teacher` (
  `Teacher_ID` int(11) NOT NULL,
  `Name` varchar(150) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Phone` int(15) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `image` blob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `teacher`
--

INSERT INTO `teacher` (`Teacher_ID`, `Name`, `Email`, `Phone`, `Password`, `image`) VALUES
(8, 'Shovon Roy', 'shovonroy@gmail.com', 1876543218, 'shovonroy', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(9, 'Rafiqul Jakir', 'rafiquljakir@gmail.com', 1627658437, 'rafiqul', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(10, 'Tonima Islam', 'tonimaislam214@gmail.com', 1319305402, 'tonima', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(11, 'Sanzida Akter', 'sanzidaaktersuraiya@gmail.com', 1557236032, 'sanzida', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(12, 'Tamima Nishat', 'nishattamima44cse@gmail.com', 1689876543, 'tamima', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(13, 'Al Rifat', 'alrifat@gmail.com', 1765432786, 'alrifat', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(14, 'Saydur Rahman', 'srrifat@gmail.com', 1987654321, 'srrifat', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(15, 'Jannatul Mimi', 'jannatulmim@gmail.com', 1876564329, 'jannatulmim', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(16, 'Shahinur Hossain', 'shahinurhossain@gmail.com', 1654765438, 'shahinur', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(17, 'Fahim Hossain', 'fahimhossain@gmail.com', 1398765432, 'fahim', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(18, 'Aurpa Datta', 'aurpadatta@gmail.com', 1476543287, 'aurpa', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(19, 'Walid Al Hasan', 'walid@gmail.com', 1876543287, 'walid', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(20, 'Imran Nazir', 'imran@gmail.com', 1376543287, 'imran', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(21, 'Nayma Siddiqa', 'nayma@gmail.com', 1876543298, 'nayma', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(22, 'Sanzida Suraiya', 'sanzidasuraiya@gmail.com', 1765432876, 'sanzida', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(23, 'Mustafizur Rahman', 'mustafizur@gmail.com', 1876543287, 'mustafizur', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(24, 'Jannatul Tisha', 'jannatultisha@gmail.com', 1987654321, 'tisha', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(25, 'Al Araf', 'alaraf@gmail.com', 1678765776, 'alaraf', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(26, 'Ariyan Ayan', 'ariyanayan@gmail.com', 1456789776, 'ariyan', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(27, 'Rohan Khan', 'rohankhan@gmail.com', 1567855543, 'rohan', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(28, 'Tuhzia Alim', 'tuhziaalim@gmail.com', 1715376598, 'tuhzia', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(29, 'Tasmia Toni', 'tasmiatoni@gmail.com', 1376543271, 'tasmia', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(30, 'Shajid Khan', 'shajidkhan@gmail.com', 1327898671, 'shajid', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765),
(31, 'Rafiqul Islam', 'rafiqulislam@gmail.com', 1876543287, 'rafiqul', 0x53797374656d2e57696e646f77732e466f726d732e50696374757265426f782c2053697a654d6f64653a2053747265746368496d616765);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`Admin_ID`,`Email`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`Student_ID`,`Email`),
  ADD UNIQUE KEY `Student_ID` (`Student_ID`,`Email`),
  ADD UNIQUE KEY `Student_ID_2` (`Student_ID`,`Email`);

--
-- Indexes for table `teacher`
--
ALTER TABLE `teacher`
  ADD PRIMARY KEY (`Teacher_ID`,`Email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `Admin_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `student`
--
ALTER TABLE `student`
  MODIFY `Student_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;

--
-- AUTO_INCREMENT for table `teacher`
--
ALTER TABLE `teacher`
  MODIFY `Teacher_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
