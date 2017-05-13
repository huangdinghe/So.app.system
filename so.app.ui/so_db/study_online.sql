/*
Navicat MySQL Data Transfer

Source Server         : Humo_MySql5.7
Source Server Version : 50717
Source Host           : localhost:3306
Source Database       : study_online

Target Server Type    : MYSQL
Target Server Version : 50717
File Encoding         : 65001

Date: 2017-05-13 16:13:33
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for classification
-- ----------------------------
DROP TABLE IF EXISTS `classification`;
CREATE TABLE `classification` (
  `classification_Id` int(11) NOT NULL AUTO_INCREMENT COMMENT '分类表',
  `classification_name` varchar(20) DEFAULT NULL,
  `parent_id` int(20) DEFAULT NULL,
  PRIMARY KEY (`classification_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of classification
-- ----------------------------

-- ----------------------------
-- Table structure for collection
-- ----------------------------
DROP TABLE IF EXISTS `collection`;
CREATE TABLE `collection` (
  `users_id` int(11) NOT NULL COMMENT '我的收藏',
  `video_id` int(11) NOT NULL,
  `my_collection` varchar(50) DEFAULT NULL,
  KEY `users_id` (`users_id`),
  KEY `collection_ibfk_1` (`video_id`),
  CONSTRAINT `collection_ibfk_1` FOREIGN KEY (`users_id`) REFERENCES `users` (`users_id`),
  CONSTRAINT `collection_ibfk_2` FOREIGN KEY (`users_id`) REFERENCES `users` (`users_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of collection
-- ----------------------------

-- ----------------------------
-- Table structure for curriculum
-- ----------------------------
DROP TABLE IF EXISTS `curriculum`;
CREATE TABLE `curriculum` (
  `CurriculumId` int(11) NOT NULL COMMENT '课程表',
  PRIMARY KEY (`CurriculumId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of curriculum
-- ----------------------------

-- ----------------------------
-- Table structure for news
-- ----------------------------
DROP TABLE IF EXISTS `news`;
CREATE TABLE `news` (
  `news_id` int(20) NOT NULL AUTO_INCREMENT COMMENT '新闻',
  PRIMARY KEY (`news_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of news
-- ----------------------------

-- ----------------------------
-- Table structure for thumbup
-- ----------------------------
DROP TABLE IF EXISTS `thumbup`;
CREATE TABLE `thumbup` (
  `users_id` int(11) DEFAULT NULL COMMENT '评论',
  `video_id` int(11) DEFAULT NULL,
  KEY `users_id` (`users_id`),
  KEY `video_id` (`video_id`),
  CONSTRAINT `thumbup_ibfk_1` FOREIGN KEY (`users_id`) REFERENCES `users` (`users_id`),
  CONSTRAINT `thumbup_ibfk_2` FOREIGN KEY (`video_id`) REFERENCES `video` (`video_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of thumbup
-- ----------------------------

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `users_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '用户表',
  `users_name` varchar(50) DEFAULT NULL,
  `password` varchar(20) DEFAULT NULL,
  `sex` bit(1) DEFAULT NULL,
  `telephone` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`users_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of users
-- ----------------------------

-- ----------------------------
-- Table structure for video
-- ----------------------------
DROP TABLE IF EXISTS `video`;
CREATE TABLE `video` (
  `video_id` int(11) NOT NULL,
  `video_name` varchar(20) DEFAULT NULL,
  `video_category` varchar(20) DEFAULT NULL,
  `url` varchar(50) DEFAULT NULL,
  `author` varchar(50) DEFAULT NULL,
  `class_file_url` varchar(50) DEFAULT NULL,
  `classification_Id` int(20) DEFAULT NULL,
  PRIMARY KEY (`video_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of video
-- ----------------------------
