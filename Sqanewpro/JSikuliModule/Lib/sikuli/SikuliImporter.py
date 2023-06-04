# Copyright 2010-2011, Sikuli.org
# Released under the MIT License.
import sys
import os
import java.lang.System
import imp
from Screen import Screen
from org.sikuli.script import Env
from org.sikuli.script import Debug
import Sikuli

def _stripPackagePrefix(module_name):
   pdot = module_name.rfind('.')
   if pdot >= 0:
      return module_name[pdot+1:]
   return module_name

class SikuliImporter:

   class SikuliLoader:
      def __init__(self, path):
         self.path = path

      def _load_module(self, fullname):
         (file, pathname, desc) =  imp.find_module(fullname)
         try:
            return imp.load_module(fullname, file, pathname, desc)
         except Exception,e:
            raise ImportError( "Errors in loading sikuli module: %s\n%s\n  - HOW TO FIX? Try adding \"from sikuli import *\" in the module.\n" %(fullname, e) )
         finally:
            if file:
               file.close()

      def load_module(self, module_name):
         #print "SikuliLoader.load_module", module_name
         module_name = _stripPackagePrefix(module_name)
         sys.path.append(self.path)
         img_path = java.lang.System.getProperty("SIKULI_IMAGE_PATH")
         if not img_path:
            img_path = ""
         elif img_path[-1] != Env.getSeparator():
            img_path += Env.getSeparator()
         img_path += self.path
         java.lang.System.setProperty("SIKULI_IMAGE_PATH", img_path)
         return self._load_module(module_name)



   def _find_module(self, module_name, fullpath):
      fullpath = fullpath + "/" + module_name + ".sikuli"
      if os.path.exists(fullpath):
         #print "SikuliImporter found", fullpath
         return self.SikuliLoader(fullpath)
      return None

   def find_module(self, module_name, package_path):
      #print "SikuliImporter.find_module", module_name, package_path
      module_name = _stripPackagePrefix(module_name)
      if package_path:
         paths = package_path
      else:
         paths = sys.path
         if not "." in paths:
            paths.append(".")
      for path in paths:
         mod = self._find_module(module_name, path)
         if mod:
            return mod
      if Sikuli.load(module_name +".jar"):
         Debug.info(module_name + ".jar loaded")
         return None

      return None


sys.meta_path.append(SikuliImporter())
del SikuliImporter
