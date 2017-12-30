# Host: localhost  (Version: 5.5.53)
# Date: 2017-12-30 15:43:04
# Generator: MySQL-Front 5.3  (Build 4.234)

/*!40101 SET NAMES utf8 */;

#
# Structure for table "login_info"
#

DROP TABLE IF EXISTS `login_info`;
CREATE TABLE `login_info` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL DEFAULT '' COMMENT '用户名',
  `pass` varchar(255) NOT NULL DEFAULT '' COMMENT '密码',
  `SF` char(1) NOT NULL DEFAULT '' COMMENT '身份标记',
  `tag` char(1) NOT NULL DEFAULT '0' COMMENT '审核标记',
  `number` varchar(255) NOT NULL DEFAULT '' COMMENT '唯一编号',
  `sex` varchar(2) NOT NULL DEFAULT '' COMMENT '性别',
  `banji` varchar(255) NOT NULL DEFAULT '' COMMENT '所属班级',
  PRIMARY KEY (`Id`),
  UNIQUE KEY `number` (`number`)
) ENGINE=MyISAM AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;

#
# Data for table "login_info"
#

/*!40000 ALTER TABLE `login_info` DISABLE KEYS */;
INSERT INTO `login_info` VALUES (1,'ad','ad','a','1','admin01','男','admin'),(2,'te','te','t','1','taccher01','男','3班'),(3,'111','111','s','1','111','男','3班'),(4,'222','222','s','1','222','女','3班'),(5,'333','333','s','1','333','男','3班'),(23,'444','4444','s','1','4444','','3班'),(24,'555','555','s','1','555','','3班');
/*!40000 ALTER TABLE `login_info` ENABLE KEYS */;

#
# Structure for table "student_score"
#

DROP TABLE IF EXISTS `student_score`;
CREATE TABLE `student_score` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `number` varchar(255) NOT NULL DEFAULT '' COMMENT '学号、教师号、管理员号（唯一编号）',
  `semester` varchar(255) NOT NULL DEFAULT '' COMMENT '课程归属学期',
  `course_name` varchar(255) NOT NULL DEFAULT '' COMMENT '课程名',
  `course_score` int(11) NOT NULL DEFAULT '0' COMMENT '成绩',
  `username` varchar(255) NOT NULL DEFAULT '' COMMENT '用户名',
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=41 DEFAULT CHARSET=utf8;

#
# Data for table "student_score"
#

/*!40000 ALTER TABLE `student_score` DISABLE KEYS */;
INSERT INTO `student_score` VALUES (9,'111','大一上学期','C语言',60,'soulsjie'),(10,'111','大一上学期','数据结构',50,'soulsjie'),(11,'111','大一上学期','C语言',60,'soulsjie'),(12,'111','大一下学期','组成原理',15,'soulsjie'),(13,'111','大三上学期','高数',15,'soulsjie'),(14,'111','大三下学期','大学物理',15,'soulsjie'),(15,'111','大二上学期','java',16,'soulsjie'),(16,'555','大二下学期','c#',60,'555'),(17,'555','大一上学期','C语言',60,'555'),(18,'111','大一上学期','数据结构',50,'soulsjie'),(19,'111','大一上学期','C语言',60,'soulsjie'),(20,'222','大一下学期','组成原理',15,'222'),(21,'222','大三上学期','高数',15,'222'),(22,'222','大三下学期','大学物理',15,'222'),(23,'222','大二上学期','java',16,'222'),(24,'555','大二下学期','c#',60,'555'),(25,'444','大一上学期','C语言',60,'444'),(26,'222','大一上学期','数据结构',50,'222'),(27,'222','大一上学期','C语言',60,'222'),(28,'222','大一下学期','组成原理',15,'222'),(29,'222','大三上学期','高数',15,'222'),(30,'333','大三下学期','大学物理',15,'333'),(31,'333','大二上学期','java',16,'333'),(32,'444','大二下学期','c#',60,'444'),(33,'444','大一上学期','C语言',60,'444'),(34,'333','大一上学期','数据结构',50,'333'),(35,'333','大一上学期','C语言',60,'333'),(36,'333','大一下学期','组成原理',15,'333'),(37,'333','大三上学期','高数',15,'333'),(38,'444','大三下学期','大学物理',15,'444'),(39,'444','大二上学期','java',16,'444'),(40,'444','大二下学期','c#',60,'444');
/*!40000 ALTER TABLE `student_score` ENABLE KEYS */;
